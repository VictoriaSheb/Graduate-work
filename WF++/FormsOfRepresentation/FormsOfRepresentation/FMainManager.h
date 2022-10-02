#pragma once
#include <iostream>
#include "ImageCombiner.h"
#include <windows.h>
#include <gdiplus.h>
#include <string.h>
#include <cmath>
#include <string>
#include <cstdlib>

#include "CriterionFunction.h"


#include <stdio.h>
#include "WorkWithImages.h"
using namespace Gdiplus;
#pragma comment (lib,"Gdiplus.lib")
class FMainManager
{
public:

	Point pointMax;
    std::string infoMetodResult;
    std::string infoMetodTime;
    std::string countCalculateCF;

    img* ConvertToBlackAndWhite(img* image)
    {
        return WorkWithImages::ConvertToBlackAndWhite(image);
    }
    CriterionFunction* StartMetodImageCombiner(img *imageII, img *imageTI, ImageCombiner *combiner, int param,int typeOfCalculator)
    {
       
           // Stopwatch stopwatch = new Stopwatch();
           // stopwatch.Start();
            Point coordinates = combiner->Start(param, typeOfCalculator);
           // stopwatch.Stop();
           pointMax = coordinates;
           infoMetodResult = "Результат: максимум = ";
           infoMetodResult += std::to_string((round(((*(combiner->CF))[coordinates]) * 100) / 100));
           infoMetodResult += ", точка (";
           infoMetodResult += std::to_string(coordinates.Y);
           infoMetodResult += ",";
           infoMetodResult += std::to_string(coordinates.X);
           infoMetodResult += ")";
         //   infoMetodTime = "Время: " + stopwatch.Elapsed + " мс";
           countCalculateCF = "Количество вычислений ЦФ: ";
           countCalculateCF += std::to_string(combiner->CF->getCount());

        return combiner->CF;
    }

    img* SelectAreaWhereImagesMatches(img* imageTI, img* imageII, Point extremum, Color highlightColor)
    {
        rectangle* area = new rectangle;
        area->X = extremum.X;
        area->Y = extremum.Y;
        area->Width = imageII->Width;
        area->Height = imageII->Height;
        return WorkWithImages::SelectAreaInImage(imageTI, *area, highlightColor);
    }


    img* DrawFCriteroin(img* image, double** FCriterion) 
    {
        return WorkWithImages::ConvertNumbersToGreenImage(image,  FCriterion, 10000);
    }
};

/*
* 
        private void FillTableCriterionFunction(CriterionFunction CF)
        {
            dgvCriterial.ColumnCount = L - M;
            dgvCriterial.RowCount = K - N;
            for (int y = 0; y < L - M; y++)
                for (int x = 0; x < K - N; x++)
                    dgvCriterial.Rows[x].Cells[y].Value = CF.Fcriterion[y, x].ToString();
        }

*/