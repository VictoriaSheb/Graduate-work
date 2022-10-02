#pragma once
#include "ImageCombiner.h"
#include <stdlib.h> // нужен для вызова функций rand(), srand()
#include <time.h> // нужен для вызова функции time()
#include <cmath>   
class Multistart : ImageCombiner
{
public:

    struct Point_t { int X; int Y; };

    int countPoints;
    Point *Points;
    Point coords;

    const int a = 1;
    const double b = 0.5;
    const double y = 2.5;
    double e = 0.001;
    const int n = 3;
    int countGroup;

    Multistart(img* fii, img* fti) : ImageCombiner(fii, fti) { }

    
    // запуск метода совмещения
    Point Start(int count, int typeOfCalculator);

    // генерация случайных точек
    Point* ThrowPoints(Point coords);
    // генерация случайных чисел
    int GetRandomNumber(int min, int max);
    // группировка 
    Point** GroupPoints(Point* points);
    // поиск точки мдм
    Point StartTheDeformablePolyhedronMethod(Point* points);
    // сортировка
    Point* Sort(Point* points, int count);

    bool CheckEnd(Point* points, Point Xmind);
    //отражение
    Point Reflect(Point Xmind, Point Xmin);
    //растяжение
    Point Stretch(Point Xmind, Point Xnew);
    //сжатие
    Point Compress(Point Xmind, Point Xmin);
    //редукция
    Point* reduction(Point* points, Point Xmax);
    Point CheckImageBorders(Point point);
};
