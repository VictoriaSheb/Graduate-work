#pragma once
#include <windows.h>
#include <gdiplus.h>
#include <stdio.h>
using namespace Gdiplus;
class CriterionFunction
{
public: 
    struct Point
    {
        int i, j;
    };

public:
    CriterionFunction(Bitmap fii, Bitmap fti);
    ~CriterionFunction();
    double** Fii;
    double** Fti;
    int K;
    int L;
    int N;
    int M;
    int Width;
    int Height;

    double** ÑalculateCriterionFunction();
    double ÑalculatePointCriterionFunction(int y, int x);
    double GetPointCriterionFunction(int y, int x);

    double** getFcriterion() 
    { 
        return Fcriterion;
    }
  
    int getCount() 
    {
        return Count;
    }

    double* operator ()(int i, int j) 
    {
        return Fcriterion[i, j];
    }
     double* operator ()(Point p) 
    {
        return Fcriterion[p.i, p.j];
    }

private:
    double** Fcriterion;//{ get; private set; }
    int Count;
};

