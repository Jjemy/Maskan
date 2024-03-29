﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace Maskan
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"type", @"type"),new InputOutputColumnPair(@"area", @"area"),new InputOutputColumnPair(@"bedrooms", @"bedrooms"),new InputOutputColumnPair(@"bathrooms", @"bathrooms"),new InputOutputColumnPair(@"furnished", @"furnished"),new InputOutputColumnPair(@"region", @"region")})      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"type",@"area",@"bedrooms",@"bathrooms",@"furnished",@"region"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.FastTreeTweedie(new FastTreeTweedieTrainer.Options(){NumberOfLeaves=17773,MinimumExampleCountPerLeaf=2,NumberOfTrees=5042,MaximumBinCountPerFeature=16,LearningRate=0.000143018463577022F,FeatureFraction=0.796137027485874F,LabelColumnName=@"price",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}
