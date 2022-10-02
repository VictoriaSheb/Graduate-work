#pragma once
#include <windows.h>
#include <gdiplus.h>
#include <stdio.h>
using namespace Gdiplus;
#pragma comment (lib,"Gdiplus.lib")

extern enum typeCalculator { Single = 0, CPU = 1, GPU = 2};
extern	struct img { int Width, Height; unsigned* Image; };
extern	struct rectangle { int X, Y, Width, Height; };