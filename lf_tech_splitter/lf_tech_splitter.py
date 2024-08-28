# https://stackoverflow.com/questions/5953373/how-to-split-image-into-multiple-pieces-in-python

import os
import sys
from PIL import Image

def CropImage (src, dest, rect):
	im = Image.open(src + ".jpg")
	a = im.crop([rect[0], rect[1], rect[0]+rect[2], rect[1]+rect[3]])
	a.save("%s.jpg" % dest, quality=85)

if __name__ == '__main__':
	print ("lf_tech_splitter Start")
	FusedImg = "2d828476bacc6b1e6bbfaf2a9fb041"
	y = [ 940, 2420, 3900, 5380 ]
	race = [ "human", "rock", "mecha", "kaelish" ]
	rn = 0
	for r in race:
		x = 0
		for i in range (1, 19):
			CropImage (FusedImg, "Images/" + r + "_t" + str(i), [x, y[rn], 100, 100] )
			x += 100
		rn += 1
	print ("lf_tech_splitter End")
