﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;

namespace ConsoleApp4
{
    public partial class MLModel1
    {
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"column1")]
            public float Column1 { get; set; }

            [ColumnName(@"type")]
            public float Type { get; set; }

            [ColumnName(@"price")]
            public float Price { get; set; }

            [ColumnName(@"area")]
            public float Area { get; set; }

            [ColumnName(@"bedrooms")]
            public float Bedrooms { get; set; }

            [ColumnName(@"bathrooms")]
            public float Bathrooms { get; set; }

            [ColumnName(@"level")]
            public float Level { get; set; }

            [ColumnName(@"furnished")]
            public float Furnished { get; set; }

            [ColumnName(@"rent")]
            public float Rent { get; set; }

            [ColumnName(@"city")]
            public string City { get; set; }

            [ColumnName(@"region")]
            public float Region { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("/Users/ahmedgamal/projects/Maskan/Assets/Price Prediction/MLModel1.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
