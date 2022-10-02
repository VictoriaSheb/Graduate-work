#pragma once
#include <windows.h>
#include <gdiplus.h>
#include <stdio.h>
#include "Constructions.h"

using namespace Gdiplus;
#pragma comment (lib,"Gdiplus.lib")
static class WorkWithImages
{
public:

	static int metod;  //1 - single; 2 - CPU; 3 - GPU
	static img* ConvertToBlackAndWhite(img *image);
	static byte** GetBits(img* bmp);

	static img* ConvertNumbersToGreenImage(img* image, double** FCriterion, int powerGreen);
	static img* SelectAreaInImage(img* imageTI, rectangle area, Color highlightColor);//?????
	static img* DrawPointOnImage(img* image, Point point, Color highlightColor);
	// vhgv, uy


};

