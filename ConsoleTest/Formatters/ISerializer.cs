﻿using Tracer;
namespace ConsoleTest
{
    public interface ISerializer
    {
         string Serialize(TraceResult traceResult);
    }
}
