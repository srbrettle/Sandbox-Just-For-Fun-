﻿namespace DijkstrasAlgorithm.Models
{
    class VertexAndShortestPathPair
    {
        readonly Vertex Vertex;
        int LowestCostPath;

        public VertexAndShortestPathPair(Vertex vertex)
        {
            this.Vertex = vertex;
            this.LowestCostPath = int.MaxValue;
        }


    }
}