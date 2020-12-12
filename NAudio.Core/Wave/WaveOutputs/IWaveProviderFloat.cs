﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NAudio.Wave
{
    /// <summary>
    /// Like IWaveProvider, but makes it much simpler to put together a 32 bit floating
    /// point mixing engine
    /// </summary>
    public interface ISampleProvider
    {
        /// <summary>
        /// Gets the WaveFormat of this Sample Provider.
        /// </summary>
        /// <value>The wave format.</value>
        WaveFormat WaveFormat { get; }

        /// <summary>
        /// Fill the specified buffer with 32 bit floating point samples
        /// </summary>
        /// <param name="buffer">The buffer to fill with samples.</param>
        /// <returns>the number of samples written to the buffer.</returns>
        int Read(Span<float> buffer);
    }
}
