#include "WorkWithImages.h"
#include <iostream>

int WorkWithImages::metod = 0;
img* WorkWithImages::ConvertToBlackAndWhite(img* image)
{
	Color t;
	unsigned color;
	unsigned gray;
	switch (metod) 
	{
	case(Single): // single
		for (int j = 0; j < image->Height; j++)
		{
			for (int i = 0; i < image->Width; i++)
			{
				color = image->Image[j * image->Width + i];
				gray = (((color & 0x00ff0000) >> 16) + ((color & 0x0000ff00) >> 8) + (color & 0x000000ff)) / 3;
				gray = 0xff000000 | (gray << 16) | (gray << 8) | gray;
				color = gray;
				image->Image[j * image->Width + i] = color;
			}
		};
		break;
	case(CPU): // CPU
		break;
	case(GPU): // GPU
		break;
	}
	return image;
}

img* WorkWithImages::SelectAreaInImage(img* imageTI, rectangle area, Color highlightColor)
{
	for (int i = 0; i < area.Width; i++)
	{
		imageTI->Image[area.Y * imageTI->Width + (area.X + i)] = highlightColor.GetValue();
		imageTI->Image[((area.Y+ area.Height) * imageTI->Width) + (area.X + i)] = highlightColor.GetValue();
	}
	for (int i = 0; i < area.Height; i++)
	{
		imageTI->Image[((area.Y + i) * imageTI->Width) + area.X] = highlightColor.GetValue();
		imageTI->Image[((area.Y + i) * imageTI->Width) + area.X + area.Width] = highlightColor.GetValue();
	}
	return imageTI;
}


img* WorkWithImages::ConvertNumbersToGreenImage(img* image, double** FCriterion, int powerGreen)
{
	int green;
	image->Image = new unsigned[(image->Height) * (image->Width)];
	for (int j = 0; j < image->Height; j++)
	{
		for (int i = 0; i < image->Width; i++)
		{
			green = FCriterion[j][i] * powerGreen;
			image->Image[j * image->Width + i] = Gdiplus::Color::MakeARGB(0xff, 0x00, green, 0x00);
		}
	}
	return image;
}