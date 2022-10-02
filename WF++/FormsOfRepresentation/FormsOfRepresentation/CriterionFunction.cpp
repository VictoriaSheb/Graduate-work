#include "CriterionFunction.h"
#include <cstdio>
#include <math.h>

CriterionFunction::CriterionFunction(img* fii, img* fti)
{
    Fii = fii;
    Fti = fti;
    K = Fti->Width;
    L = Fti->Height;
    N = Fii->Width;
    M = Fii->Height;
    Height = L - M;
    Width = K - N;
    Fcriterion = new double* [Height];
    for (int y = 0; y < Height; y++)
    {
        Fcriterion[y] = (double*)malloc(Width * sizeof(double));
        for (int x = 0; x < Width; x++)
            Fcriterion[y][x] = 0;
    }
    Count = 0;
}

double** CriterionFunction::ÑalculateCriterionFunction(int typeOfCalculator)
{
    switch (typeOfCalculator)
    {
    case Single:
        ÑalculateCriterionFunction_Single();
        break;
    case CPU:
        break;
    case GPU:
        break;
    }
    return Fcriterion;

}

double** CriterionFunction::ÑalculateCriterionFunction_Single()
{
    int sumFii = 1;
    int sumFti = 1;
    double sumFiiSquared = 0;
    double sumFtiSquared = 0;
    double sumFtiMultiplyFii = 0;
    for (int y = 0; y < Height; y++)
        for (int x = 0; x < Width; x++)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    sumFti = (Fti->Image[(j + y) * (Fti->Width) + (i + x)])&0xff;
                    sumFii = (Fii->Image[j * (Fii->Width) + i])&0xff;
                    sumFiiSquared += sumFii * sumFii;
                    sumFtiSquared += sumFti * sumFti;
                    sumFtiMultiplyFii += sumFii * sumFti;
                }
            Fcriterion[y][x] = sumFtiMultiplyFii / (sqrt(sumFiiSquared * sumFtiSquared));
            Count++;
            sumFtiMultiplyFii = sumFtiSquared = sumFiiSquared = 0;
        }
    return Fcriterion;
}

double CriterionFunction::ÑalculatePointCriterionFunction(int y, int x)
{
    int sumFii = 1;
    int sumFti = 1;
    double sumFiiSquared = 0;
    double sumFtiSquared = 0;
    double sumFtiMultiplyFii = 0;
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
        {
            sumFti = (Fti->Image[(j + y) * (Fti->Width) + (i + x)]) & 0xff;
            sumFii = (Fii->Image[j * (Fii->Width) + i]) & 0xff;
            sumFiiSquared += sumFii * sumFii;
            sumFtiSquared += sumFti * sumFti;
            sumFtiMultiplyFii += sumFii * sumFti;
        }
    Fcriterion[y][x] = sumFtiMultiplyFii / sqrt(sumFiiSquared * sumFtiSquared);
    double ccdc = Fcriterion[y][x];
    Count++;
    return (double)Fcriterion[y][x];
}

double CriterionFunction::GetPointCriterionFunction(int y, int x)
{
    double sds = Fcriterion[y][x];
    if (Fcriterion[y][x] == 0)
    {
        return ÑalculatePointCriterionFunction(y, x);
    }
    else
        return (double)Fcriterion[y][x];
}