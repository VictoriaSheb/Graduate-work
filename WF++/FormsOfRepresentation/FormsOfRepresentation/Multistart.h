#pragma once
#include "ImageCombiner.h"
#include <stdlib.h> // ����� ��� ������ ������� rand(), srand()
#include <time.h> // ����� ��� ������ ������� time()
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

    
    // ������ ������ ����������
    Point Start(int count, int typeOfCalculator);

    // ��������� ��������� �����
    Point* ThrowPoints(Point coords);
    // ��������� ��������� �����
    int GetRandomNumber(int min, int max);
    // ����������� 
    Point** GroupPoints(Point* points);
    // ����� ����� ���
    Point StartTheDeformablePolyhedronMethod(Point* points);
    // ����������
    Point* Sort(Point* points, int count);

    bool CheckEnd(Point* points, Point Xmind);
    //���������
    Point Reflect(Point Xmind, Point Xmin);
    //����������
    Point Stretch(Point Xmind, Point Xnew);
    //������
    Point Compress(Point Xmind, Point Xmin);
    //��������
    Point* reduction(Point* points, Point Xmax);
    Point CheckImageBorders(Point point);
};
