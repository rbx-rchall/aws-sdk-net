/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the StopBulkDeployment operation.
    /// Stops the execution of a bulk deployment. This action returns a status of ''Stopping''
    /// until the deployment is stopped. You cannot start a new bulk deployment while a previous
    /// deployment is in the ''Stopping'' state. This action doesn't rollback completed deployments
    /// or cancel pending deployments.
    /// </summary>
    public partial class StopBulkDeploymentRequest : AmazonGreengrassRequest
    {
        private string _bulkDeploymentId;

        /// <summary>
        /// Gets and sets the property BulkDeploymentId. The ID of the bulk deployment.
        /// </summary>
        public string BulkDeploymentId
        {
            get { return this._bulkDeploymentId; }
            set { this._bulkDeploymentId = value; }
        }

        // Check to see if BulkDeploymentId property is set
        internal bool IsSetBulkDeploymentId()
        {
            return this._bulkDeploymentId != null;
        }

    }
}