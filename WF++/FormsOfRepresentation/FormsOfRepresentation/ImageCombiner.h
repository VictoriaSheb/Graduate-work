#pragma once
#include "CriterionFunction.h"
#include <windows.h>
#include <gdiplus.h>
#include <stdio.h>
using namespace Gdiplus;
#pragma comment (lib,"Gdiplus.lib")
class ImageCombiner
{
public:
    ImageCombiner(img *fii, img *fti)
    {
        CF = new CriterionFunction(fii, fti);
    };

    CriterionFunction *CF;
    Point getExtremalPoint()    { return ExtremalPoint; }
    double getExtremum() { return (*CF)[ExtremalPoint];}

    virtual Point Start(int count, int typeOfCalculator)=0;
protected:
    Point ExtremalPoint;
};

