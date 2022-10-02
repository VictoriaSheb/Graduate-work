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

    double** �alculateCriterionFunction(int typeOfCalculator);
    //Single
    double** �alculateCriterionFunction_Single();
    //CPU
    double** �alculateCriterionFunction_CPU();
    //GPU
    double** �alculateCriterionFunction_GPU();

    double �alculatePointCriterionFunction(int y, int x);
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

