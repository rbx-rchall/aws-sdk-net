/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricsConfiguration Unmarshaller 
    /// </summary>   
    internal class MetricsConfigurationUnmarshaller : IUnmarshaller<MetricsConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MetricsConfiguration, JsonUnmarshallerContext> 
    {
        public MetricsConfiguration Unmarshall(XmlUnmarshallerContext context) 
        {
            MetricsConfiguration response = new MetricsConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        response.MetricsFilter = new MetricsFilter(){
                          MetricsFilterPredicate = (MetricsPredicateListFilterUnmarshaller.Instance.Unmarshall(context))[0]
                    };
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        response.MetricsId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return response;
                }
            }



            return response;
        }

        public MetricsConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static MetricsConfigurationUnmarshaller _instance;

        public static MetricsConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MetricsConfigurationUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
