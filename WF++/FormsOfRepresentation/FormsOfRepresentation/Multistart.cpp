#include "Multistart.h"


Point Multistart::Start(int count, int typeOfCalculator)
{
  //  CF->СalculateCriterionFunction(typeOfCalculator);
    countGroup = count;
    int y = CF->Height;
    int x = CF->Width;
    coords.Y = y;
    coords.X = x;
    Point* pointsResults = new Point[countGroup];
    countPoints = countGroup * n;
    int iterator = 0;
    Point** groups;
    groups = GroupPoints(ThrowPoints(coords));
    for (int group = 0;group < countGroup;group++)
    {
        pointsResults[group] = StartTheDeformablePolyhedronMethod(groups[group]);
    }
     pointsResults = Sort(pointsResults, countGroup);
     return pointsResults[countGroup - 1];

}

Point* Multistart::ThrowPoints(Point coords)
{
    Points = new Point[countPoints];
    for (int i = 0; i < countPoints; i++)
    {
        Points[i].X = GetRandomNumber(0, coords.X - 1);
        Points[i].Y = GetRandomNumber(0, coords.Y - 1);
    }
    return Points;
}

int Multistart::GetRandomNumber(int min, int max)
{
    //srand(time(NULL));
    int num = min + rand() % (max - min + 1);
    return num;
}

Point** Multistart::GroupPoints(Point *points)
{
  //  Point *group = new Point[n];
    Point** groups = new Point * [countGroup];
    for (int i = 0; i < countGroup; i++)
    {
        groups[i] = new Point[n];
        for (int j = 0; j < n; j++)
            groups[i][j] = points[i * n + j];
        Point q0 = groups[i][0];
        Point q1 = groups[i][1];
        Point q2 = groups[i][2];
       // groups[i] = group;
    }
    return groups;
}

Point Multistart::StartTheDeformablePolyhedronMethod(Point* points)
{
    Point Xmin0(points[n - 1].X, points[n - 1].Y);
    Point result;
    bool end = false;
    while (!end)
    {
        points = Sort(points, n);
        Point Xmax(points[n - 1].X, points[n - 1].Y);
        Point Xmax2(points[n - 2].X, points[n - 2].Y);
        Point Xmin(points[0].X, points[0].Y);
        if ((Xmin.X == Xmin0.X) && (Xmin.Y == Xmin0.Y))
        {
            result = points[n - 1];
            end = true;
            return result;
        }
        else
        {
            Xmin0 = Xmin;
        }
        Point Xmind(0, 0);
        for (int i = 1; i < n; i++)
        {
            Xmind.X += points[i].X;
            Xmind.Y += points[i].Y;
        }
        Xmind.X = Xmind.X / (n - 1);
        Xmind.Y = Xmind.Y / (n - 1);
        if (CheckEnd(points, Xmind))
        {
            points = Sort(points, n);
            result = points[n - 1];
            end = true;
            return result;
        }
        Point Xnew1 = Reflect(Xmind, Xmin);
        Point Xnew2;
        if ((*CF)[Xnew1] > (*CF)[Xmax])
        {
            Xnew2 = Stretch(Xmind, Xnew1);
            if ((*CF)[Xnew2] > (*CF)[Xmax])
                points[0] = Xnew2;
            else
                points[0] = Xnew1;
            continue;
        }
        if ((*CF)[Xnew1] < (*CF)[Xmax2] && (*CF)[Xnew1] >= (*CF)[Xmin])
        {
            Xnew2 = Compress(Xmind, Xmin);
            points[0] = Xnew2;
            continue;
        }
        if ((*CF)[Xnew1] < (*CF)[Xmax] && (*CF)[Xnew1] >= (*CF)[Xmax2])
        {
            points[0] = Xnew1;
            continue;
        }
        if ((*CF)[Xnew1] < (*CF)[Xmin])
        {
            points = reduction(points, Xmax);
            continue;
        }
    }
    return result;
}


//отражение
Point Multistart::Reflect(Point Xmind, Point Xmin)
{
    Point result;
    result =  Point((Xmind.X + a * (Xmind.X - Xmin.X)), (Xmind.Y + a * (Xmind.Y - Xmin.Y)));
    result = CheckImageBorders(result);
    return result;
}

//растяжение
Point Multistart::Stretch(Point Xmind, Point Xnew)
{
    Point result;
    result = Point(Xmind.X + (int)(y * (Xnew.X - Xmind.X)), Xmind.Y + (int)(y * (Xnew.Y - Xmind.Y)));
    result = CheckImageBorders(result);
    return result;
}

//сжатие
Point Multistart::Compress(Point Xmind, Point Xmin)
{
    Point result;
    result = Point(Xmind.X + (int)(b * (Xmin.X - Xmind.X)), Xmind.Y + (int)(b * (Xmin.Y - Xmind.Y)));
    result = CheckImageBorders(result);
    return result;
}


//редукция
Point* Multistart::reduction(Point* points, Point Xmax)
{
    for (int i = 0; i < n; i++)
    {
        points[i] = Point(Xmax.X + (int)(0.5 * (points[i].X - Xmax.X)), Xmax.Y + (int)(0.5 * (points[i].Y - Xmax.Y)));
        points[i] = CheckImageBorders(points[i]);
    }
    return points;
}

Point Multistart::CheckImageBorders(Point point)
{
    if (point.X < 0)
        point.X = 0;
    if (point.X >= coords.X)
        point.X = coords.X - 1;
    if (point.Y < 0)
        point.Y = 0;
    if (point.Y >= coords.Y)
        point.Y = coords.Y - 1;
    return point;
}

bool Multistart::CheckEnd(Point* points, Point Xmind)
{
    double result = 0;
    double help = 0.0;
    for (int i = 0; i < n; i++)
    {
        help = (*CF)[points[i]] - (*CF)[Xmind];
        result += help * help;
    }
    result = sqrt(result / n);
    if (result <= e)
        return true;
    else
        return false;
}




  Point* Multistart::Sort(Point* points, int count)
  {
      Point temp; 
      Point q0 = points[0];
      Point q1 = points[1];
      Point q2 = points[2];
      for (int i = 0; i < count - 1; i++) {
          for (int j = 0; j < count - i - 1; j++) {
              if ((*CF)[points[j]] > (*CF)[points[j + 1]]) {
                  // меняем элементы местами
                  temp = points[j];
                  points[j] = points[j + 1];
                  points[j + 1] = temp;
              }
          }
      }
      return points;
  }
