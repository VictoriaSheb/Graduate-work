#pragma once
#include "Constructions.h"
class CriterionFunction
{
public:
    CriterionFunction(img *fii, img *fti);
    ~CriterionFunction();
    img* Fii;
    img* Fti;
    int K;
    int L;
    int N;
    int M;
    int Width;
    int Height;

    double** ÑalculateCriterionFunction(int typeOfCalculator);
    //Single
    double** ÑalculateCriterionFunction_Single();
    //CPU
    double** ÑalculateCriterionFunction_CPU();
    //GPU
    double** ÑalculateCriterionFunction_GPU();

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

    double operator ()(int i, int j)
    {
        return GetPointCriterionFunction(i,j);
    }
   double operator [](Point p)
    {
        return GetPointCriterionFunction(p.Y,p.X);
    }



private:
    double** Fcriterion;//{ get; private set; }
    int Count;
};

