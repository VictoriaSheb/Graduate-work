#pragma once
#include "ImageCombiner.h"

class TotallyOverkill : ImageCombiner
{
public: 
	TotallyOverkill(img *fii, img *fti) : ImageCombiner(fii, fti) { }
	Point Start(int count,int typeOfCalculator)
    {
        CF->—alculateCriterionFunction(typeOfCalculator);
        Point current—oordinate;
        double max = 0;
        for (int i = 0; i < CF->Height; ++i)
            for (int j = 0; j < CF->Width; ++j)
                if (max < ((*CF)(i, j)))
                {
                    max = (*CF)(i, j);
                    current—oordinate.X = j;
                    current—oordinate.Y = i;
                }
        return current—oordinate;
    }


};

