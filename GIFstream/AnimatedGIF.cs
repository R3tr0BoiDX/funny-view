using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

public class AnimatedGIF {
	private int currentFrame = -1;
	private int step = 1;

	public List<AnimatedGIFFrame> Images { get; } = new List<AnimatedGIFFrame>();

	public int Frames {
		get;
		private set;
	}

	public AnimatedGIF(string _path) {
		Image gif = Image.FromFile(_path);
		Frames = gif.GetFrameCount(FrameDimension.Time);

		if (Frames <= 1) {
			throw new ArgumentException("Image not animated");
		}

		byte[] times = gif.GetPropertyItem(0x5100).Value;
		int frame = 0;
		while (true) {
			int dur = BitConverter.ToInt32(times, 4 * frame);
			Images.Add(new AnimatedGIFFrame(new Bitmap(gif), dur));
			if (++frame >= Frames) {
				break;
			}

			gif.SelectActiveFrame(FrameDimension.Time, frame);
		}

		gif.Dispose();
	}

	public AnimatedGIFFrame GetNextFrame() {
		currentFrame += step;

		if (currentFrame >= Frames || currentFrame < 1) {
			currentFrame = 0;
		}
		return Images[currentFrame];
	}
}

public class AnimatedGIFFrame {

	internal AnimatedGIFFrame(Image img, int duration) {
		frame = img;
		Duration = duration;
	}

	public Image frame {
		get;
	}

	public int Duration {
		get;
	}
}