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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectConnect.Model;
using Amazon.DirectConnect.Model.Internal.MarshallTransformations;
using Amazon.DirectConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Implementation for accessing DirectConnect
    ///
    /// AWS Direct Connect links your internal network to an AWS Direct Connect location over
    /// a standard Ethernet fiber-optic cable. One end of the cable is connected to your router,
    /// the other to an AWS Direct Connect router. With this connection in place, you can
    /// create virtual interfaces directly to the AWS cloud (for example, to Amazon EC2 and
    /// Amazon S3) and to Amazon VPC, bypassing Internet service providers in your network
    /// path. A connection provides access to all AWS Regions except the China (Beijing) and
    /// (China) Ningxia Regions. AWS resources in the China Regions can only be accessed through
    /// locations associated with those Regions.
    /// </summary>
    public partial class AmazonDirectConnectClient : AmazonServiceClient, IAmazonDirectConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectConnectMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDirectConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AmazonDirectConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials and an
        /// AmazonDirectConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AllocateConnectionOnInterconnect


        /// <summary>
        /// Deprecated. Use <a>AllocateHostedConnection</a> instead.
        /// 
        ///  
        /// <para>
        /// Creates a hosted connection on an interconnect.
        /// </para>
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        public virtual AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateConnectionOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<AllocateConnectionOnInterconnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        public virtual Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateConnectionOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;
            
            return InvokeAsync<AllocateConnectionOnInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateHostedConnection


        /// <summary>
        /// Creates a hosted connection on the specified interconnect or a link aggregation group
        /// (LAG).
        /// 
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the specified interconnect or LAG.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AllocateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        public virtual AllocateHostedConnectionResponse AllocateHostedConnection(AllocateHostedConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AllocateHostedConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        public virtual Task<AllocateHostedConnectionResponse> AllocateHostedConnectionAsync(AllocateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<AllocateHostedConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocatePrivateVirtualInterface


        /// <summary>
        /// Provisions a private virtual interface to be owned by the specified AWS account.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces created using this action must be confirmed by the owner using
        /// <a>ConfirmPrivateVirtualInterface</a>. Until then, the virtual interface is in the
        /// <code>Confirming</code> state and is not available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        public virtual AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePrivateVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        public virtual Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AllocatePrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocatePublicVirtualInterface


        /// <summary>
        /// Provisions a public virtual interface to be owned by the specified AWS account.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a public virtual interface
        /// to be owned by the specified AWS account.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the owner using
        /// <a>ConfirmPublicVirtualInterface</a>. Until this step has been completed, the virtual
        /// interface is in the <code>confirming</code> state and is not available to handle traffic.
        /// </para>
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface, omit the Amazon address and customer
        /// address. IPv6 addresses are automatically assigned from the Amazon pool of IPv6 addresses;
        /// you cannot specify custom IPv6 addresses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePublicVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AllocatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateConnectionWithLag


        /// <summary>
        /// Associates an existing connection with a link aggregation group (LAG). The connection
        /// is interrupted and re-established as a member of the LAG (connectivity to AWS is interrupted).
        /// The connection must be hosted on the same AWS Direct Connect endpoint as the LAG,
        /// and its bandwidth must match the bandwidth for the LAG. You can re-associate a connection
        /// that's currently associated with a different LAG; however, if removing the connection
        /// would cause the original LAG to fall below its setting for minimum number of operational
        /// connections, the request fails.
        /// 
        ///  
        /// <para>
        /// Any virtual interfaces that are directly associated with the connection are automatically
        /// re-associated with the LAG. If the connection was originally associated with a different
        /// LAG, the virtual interfaces remain associated with the original LAG.
        /// </para>
        ///  
        /// <para>
        /// For interconnects, any hosted connections are automatically re-associated with the
        /// LAG. If the interconnect was originally associated with a different LAG, the hosted
        /// connections remain associated with the original LAG.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag service method.</param>
        /// 
        /// <returns>The response from the AssociateConnectionWithLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        public virtual AssociateConnectionWithLagResponse AssociateConnectionWithLag(AssociateConnectionWithLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionWithLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectionWithLagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectionWithLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        public virtual Task<AssociateConnectionWithLagResponse> AssociateConnectionWithLagAsync(AssociateConnectionWithLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionWithLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateConnectionWithLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateHostedConnection


        /// <summary>
        /// Associates a hosted connection and its virtual interfaces with a link aggregation
        /// group (LAG) or interconnect. If the target interconnect or LAG has an existing hosted
        /// connection with a conflicting VLAN number or IP address, the operation fails. This
        /// action temporarily interrupts the hosted connection's connectivity to AWS as it is
        /// being migrated.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection service method.</param>
        /// 
        /// <returns>The response from the AssociateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual AssociateHostedConnectionResponse AssociateHostedConnection(AssociateHostedConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AssociateHostedConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual Task<AssociateHostedConnectionResponse> AssociateHostedConnectionAsync(AssociateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateHostedConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateVirtualInterface


        /// <summary>
        /// Associates a virtual interface with a specified link aggregation group (LAG) or connection.
        /// Connectivity to AWS is temporarily interrupted as the virtual interface is being migrated.
        /// If the target connection or LAG has an associated virtual interface with a conflicting
        /// VLAN number or a conflicting IP address, the operation fails.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces associated with a hosted connection cannot be associated with a
        /// LAG; hosted connections must be migrated along with their virtual interfaces using
        /// <a>AssociateHostedConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// To reassociate a virtual interface to a new connection or LAG, the requester must
        /// own either the virtual interface itself or the connection to which the virtual interface
        /// is currently associated. Additionally, the requester must own the connection or LAG
        /// for the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the AssociateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        public virtual AssociateVirtualInterfaceResponse AssociateVirtualInterface(AssociateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AssociateVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        public virtual Task<AssociateVirtualInterfaceResponse> AssociateVirtualInterfaceAsync(AssociateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmConnection


        /// <summary>
        /// Confirms the creation of the specified hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the <code>Ordering</code> state,
        /// and remains in this state until the owner confirms creation of the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return Invoke<ConfirmConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConfirmConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPrivateVirtualInterface


        /// <summary>
        /// Accepts ownership of a private virtual interface created by another AWS account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the virtual interface is created
        /// and attached to the specified virtual private gateway or Direct Connect gateway, and
        /// is made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        public virtual ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPrivateVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConfirmPrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPublicVirtualInterface


        /// <summary>
        /// Accepts ownership of a public virtual interface created by another AWS account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the specified virtual interface
        /// is created and made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPublicVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConfirmPublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBGPPeer


        /// <summary>
        /// Creates a BGP peer on the specified virtual interface.
        /// 
        ///  
        /// <para>
        /// You must create a BGP peer for the corresponding address family (IPv4/IPv6) in order
        /// to access AWS resources that also use that address family.
        /// </para>
        ///  
        /// <para>
        /// If logical redundancy is not supported by the connection, interconnect, or LAG, the
        /// BGP peer cannot be in the same address family as an existing BGP peer on the virtual
        /// interface.
        /// </para>
        ///  
        /// <para>
        /// When creating a IPv6 BGP peer, omit the Amazon address and customer address. IPv6
        /// addresses are automatically assigned from the Amazon pool of IPv6 addresses; you cannot
        /// specify custom IPv6 addresses.
        /// </para>
        ///  
        /// <para>
        /// For a public virtual interface, the Autonomous System Number (ASN) must be private
        /// or already whitelisted for the virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer service method.</param>
        /// 
        /// <returns>The response from the CreateBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        public virtual CreateBGPPeerResponse CreateBGPPeer(CreateBGPPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;

            return Invoke<CreateBGPPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        public virtual Task<CreateBGPPeerResponse> CreateBGPPeerAsync(CreateBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBGPPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection


        /// <summary>
        /// Creates a connection between a customer network and a specific AWS Direct Connect
        /// location.
        /// 
        ///  
        /// <para>
        /// A connection links your internal network to an AWS Direct Connect location over a
        /// standard Ethernet fiber-optic cable. One end of the cable is connected to your router,
        /// the other to an AWS Direct Connect router.
        /// </para>
        ///  
        /// <para>
        /// To find the locations for your Region, use <a>DescribeLocations</a>.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new connection to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new connection is allocated
        /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
        /// no available ports on the endpoint, the request fails and no connection is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGateway


        /// <summary>
        /// Creates a Direct Connect gateway, which is an intermediate object that enables you
        /// to connect a set of virtual interfaces and virtual private gateways. A Direct Connect
        /// gateway is global and visible in any AWS Region after it is created. The virtual interfaces
        /// and virtual private gateways that are connected through a Direct Connect gateway can
        /// be in different AWS Regions. This enables you to connect to a VPC in any Region, regardless
        /// of the Region in which the virtual interfaces are located, and pass traffic between
        /// them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        public virtual CreateDirectConnectGatewayResponse CreateDirectConnectGateway(CreateDirectConnectGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGatewayAsync(CreateDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDirectConnectGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGatewayAssociation


        /// <summary>
        /// Creates an association between a Direct Connect gateway and a virtual private gateway.
        /// The virtual private gateway must be attached to a VPC and must not be associated with
        /// another Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual CreateDirectConnectGatewayAssociationResponse CreateDirectConnectGatewayAssociation(CreateDirectConnectGatewayAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayAssociationResponse> CreateDirectConnectGatewayAssociationAsync(CreateDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInterconnect


        /// <summary>
        /// Creates an interconnect between an AWS Direct Connect partner's network and a specific
        /// AWS Direct Connect location.
        /// 
        ///  
        /// <para>
        /// An interconnect is a connection which is capable of hosting other connections. The
        /// partner can use an interconnect to provide sub-1Gbps AWS Direct Connect service to
        /// tier 2 customers who do not have their own connections. Like a standard connection,
        /// an interconnect links the partner's network to an AWS Direct Connect location over
        /// a standard Ethernet fiber-optic cable. One end is connected to the partner's router,
        /// the other to an AWS Direct Connect router.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new interconnect to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new interconnect is allocated
        /// on the same AWS Direct Connect endpoint that hosts the specified LAG. If there are
        /// no available ports on the endpoint, the request fails and no interconnect is created.
        /// </para>
        ///  
        /// <para>
        /// For each end customer, the AWS Direct Connect partner provisions a connection on their
        /// interconnect by calling <a>AllocateConnectionOnInterconnect</a>. The end customer
        /// can then connect to AWS resources by creating a virtual interface on their connection,
        /// using the VLAN assigned to them by the partner.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        public virtual CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInterconnectResponseUnmarshaller.Instance;

            return Invoke<CreateInterconnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        public virtual Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInterconnectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLag


        /// <summary>
        /// Creates a link aggregation group (LAG) with the specified number of bundled physical
        /// connections between the customer network and a specific AWS Direct Connect location.
        /// A LAG is a logical interface that uses the Link Aggregation Control Protocol (LACP)
        /// to aggregate multiple interfaces, enabling you to treat them as a single interface.
        /// 
        ///  
        /// <para>
        /// All connections in a LAG must use the same bandwidth and must terminate at the same
        /// AWS Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 connections per LAG. Regardless of this limit, if you request
        /// more connections for the LAG than AWS Direct Connect can allocate on a single endpoint,
        /// no LAG is created.
        /// </para>
        ///  
        /// <para>
        /// You can specify an existing physical connection or interconnect to include in the
        /// LAG (which counts towards the total number of connections). Doing so interrupts the
        /// current physical connection or hosted connections, and re-establishes them as a member
        /// of the LAG. The LAG will be created on the same AWS Direct Connect endpoint to which
        /// the connection terminates. Any virtual interfaces associated with the connection are
        /// automatically disassociated and re-associated with the LAG. The connection ID does
        /// not change.
        /// </para>
        ///  
        /// <para>
        /// If the AWS account used to create a LAG is a registered AWS Direct Connect partner,
        /// the LAG is automatically enabled to host sub-connections. For a LAG owned by a partner,
        /// any associated virtual interfaces cannot be directly configured.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLag service method.</param>
        /// 
        /// <returns>The response from the CreateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        public virtual CreateLagResponse CreateLag(CreateLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLagResponseUnmarshaller.Instance;

            return Invoke<CreateLagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        public virtual Task<CreateLagResponse> CreateLagAsync(CreateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLagResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePrivateVirtualInterface


        /// <summary>
        /// Creates a private virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A private virtual interface can be connected to either
        /// a Direct Connect gateway or a Virtual Private Gateway (VGW). Connecting the private
        /// virtual interface to a Direct Connect gateway enables the possibility for connecting
        /// to multiple VPCs, including VPCs in different AWS Regions. Connecting the private
        /// virtual interface to a VGW only provides access to a single VPC within the same Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        public virtual CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        public virtual Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicVirtualInterface


        /// <summary>
        /// Creates a public virtual interface. A virtual interface is the VLAN that transports
        /// AWS Direct Connect traffic. A public virtual interface supports sending traffic to
        /// public services of AWS such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (<code>addressFamily</code> is <code>ipv6</code>),
        /// leave the <code>customer</code> and <code>amazon</code> address fields blank to use
        /// auto-assigned IPv6 space. Custom IPv6 addresses are not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePublicVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBGPPeer


        /// <summary>
        /// Deletes the specified BGP peer on the specified virtual interface with the specified
        /// customer address and ASN.
        /// 
        ///  
        /// <para>
        /// You cannot delete the last BGP peer from a virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer service method.</param>
        /// 
        /// <returns>The response from the DeleteBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        public virtual DeleteBGPPeerResponse DeleteBGPPeer(DeleteBGPPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;

            return Invoke<DeleteBGPPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        public virtual Task<DeleteBGPPeerResponse> DeleteBGPPeerAsync(DeleteBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBGPPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection


        /// <summary>
        /// Deletes the specified connection.
        /// 
        ///  
        /// <para>
        /// Deleting a connection only stops the AWS Direct Connect port hour and data transfer
        /// charges. If you are partnering with any third parties to connect with the AWS Direct
        /// Connect location, you must cancel your service with them separately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGateway


        /// <summary>
        /// Deletes the specified Direct Connect gateway. You must first delete all virtual interfaces
        /// that are attached to the Direct Connect gateway and disassociate all virtual private
        /// gateways that are associated with the Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        public virtual DeleteDirectConnectGatewayResponse DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGatewayAsync(DeleteDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDirectConnectGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociation


        /// <summary>
        /// Deletes the association between the specified Direct Connect gateway and virtual private
        /// gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual DeleteDirectConnectGatewayAssociationResponse DeleteDirectConnectGatewayAssociation(DeleteDirectConnectGatewayAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayAssociationResponse> DeleteDirectConnectGatewayAssociationAsync(DeleteDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInterconnect


        /// <summary>
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        public virtual DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;

            return Invoke<DeleteInterconnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        public virtual Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLag


        /// <summary>
        /// Deletes the specified link aggregation group (LAG). You cannot delete a LAG if it
        /// has active virtual interfaces or hosted connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag service method.</param>
        /// 
        /// <returns>The response from the DeleteLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        public virtual DeleteLagResponse DeleteLag(DeleteLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLagResponseUnmarshaller.Instance;

            return Invoke<DeleteLagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        public virtual Task<DeleteLagResponse> DeleteLagAsync(DeleteLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLagResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualInterface


        /// <summary>
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        public virtual DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualInterfaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        public virtual Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionLoa


        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
        /// <para>
        /// Gets the LOA-CFA for a connection.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that your APN partner or service provider uses when establishing your cross connect
        /// to AWS at the colocation facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the <i>AWS Direct Connect User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual DescribeConnectionLoaResponse DescribeConnectionLoa(DescribeConnectionLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionLoaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeConnectionLoaResponse> DescribeConnectionLoaAsync(DescribeConnectionLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectionLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections()
        {
            return DescribeConnections(new DescribeConnectionsRequest());
        }


        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConnectionsAsync(new DescribeConnectionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionsOnInterconnect


        /// <summary>
        /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
        /// 
        ///  
        /// <para>
        /// Lists the connections that have been provisioned on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        public virtual DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsOnInterconnectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        public virtual Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectionsOnInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociations


        /// <summary>
        /// Lists the associations between your Direct Connect gateways and virtual private gateways.
        /// You must specify a Direct Connect gateway, a virtual private gateway, or both. If
        /// you specify a Direct Connect gateway, the response contains all virtual private gateways
        /// associated with the Direct Connect gateway. If you specify a virtual private gateway,
        /// the response contains all Direct Connect gateways associated with the virtual private
        /// gateway. If you specify both, the response contains the association between the Direct
        /// Connect gateway and the virtual private gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        public virtual DescribeDirectConnectGatewayAssociationsResponse DescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAssociationsResponse> DescribeDirectConnectGatewayAssociationsAsync(DescribeDirectConnectGatewayAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDirectConnectGatewayAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAttachments


        /// <summary>
        /// Lists the attachments between your Direct Connect gateways and virtual interfaces.
        /// You must specify a Direct Connect gateway, a virtual interface, or both. If you specify
        /// a Direct Connect gateway, the response contains all virtual interfaces attached to
        /// the Direct Connect gateway. If you specify a virtual interface, the response contains
        /// all Direct Connect gateways attached to the virtual interface. If you specify both,
        /// the response contains the attachment between the Direct Connect gateway and the virtual
        /// interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAttachments service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        public virtual DescribeDirectConnectGatewayAttachmentsResponse DescribeDirectConnectGatewayAttachments(DescribeDirectConnectGatewayAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAttachmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAttachmentsResponse> DescribeDirectConnectGatewayAttachmentsAsync(DescribeDirectConnectGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDirectConnectGatewayAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGateways


        /// <summary>
        /// Lists all your Direct Connect gateways or only the specified Direct Connect gateway.
        /// Deleted Direct Connect gateways are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        public virtual DescribeDirectConnectGatewaysResponse DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGatewaysAsync(DescribeDirectConnectGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDirectConnectGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostedConnections


        /// <summary>
        /// Lists the hosted connections that have been provisioned on the specified interconnect
        /// or link aggregation group (LAG).
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by AWS Direct Connect partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeHostedConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        public virtual DescribeHostedConnectionsResponse DescribeHostedConnections(DescribeHostedConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostedConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostedConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostedConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        public virtual Task<DescribeHostedConnectionsResponse> DescribeHostedConnectionsAsync(DescribeHostedConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostedConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeHostedConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnectLoa


        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
        /// <para>
        /// Gets the LOA-CFA for the specified interconnect.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to AWS at the colocation facility.
        /// For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the <i>AWS Direct Connect User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnectLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual DescribeInterconnectLoaResponse DescribeInterconnectLoa(DescribeInterconnectLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectLoaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeInterconnectLoaResponse> DescribeInterconnectLoaAsync(DescribeInterconnectLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInterconnectLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnects


        /// <summary>
        /// Lists the interconnects owned by the AWS account or only the specified interconnect.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual DescribeInterconnectsResponse DescribeInterconnects()
        {
            return DescribeInterconnects(new DescribeInterconnectsRequest());
        }


        /// <summary>
        /// Lists the interconnects owned by the AWS account or only the specified interconnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectsResponse>(request, options);
        }


        /// <summary>
        /// Lists the interconnects owned by the AWS account or only the specified interconnect.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInterconnectsAsync(new DescribeInterconnectsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInterconnectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLags


        /// <summary>
        /// Describes all your link aggregation groups (LAG) or the specified LAG.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags service method.</param>
        /// 
        /// <returns>The response from the DescribeLags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        public virtual DescribeLagsResponse DescribeLags(DescribeLagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLagsResponseUnmarshaller.Instance;

            return Invoke<DescribeLagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        public virtual Task<DescribeLagsResponse> DescribeLagsAsync(DescribeLagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoa


        /// <summary>
        /// Gets the LOA-CFA for a connection, interconnect, or link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to AWS at the colocation facility.
        /// For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at AWS Direct Connect Locations</a> in the <i>AWS Direct Connect User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa service method.</param>
        /// 
        /// <returns>The response from the DescribeLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        public virtual DescribeLoaResponse DescribeLoa(DescribeLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeLoaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        public virtual Task<DescribeLoaResponse> DescribeLoaAsync(DescribeLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoaResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocations


        /// <summary>
        /// Lists the AWS Direct Connect locations in the current AWS Region. These are the locations
        /// that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual DescribeLocationsResponse DescribeLocations()
        {
            return DescribeLocations(new DescribeLocationsRequest());
        }


        /// <summary>
        /// Lists the AWS Direct Connect locations in the current AWS Region. These are the locations
        /// that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the AWS Direct Connect locations in the current AWS Region. These are the locations
        /// that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLocationsAsync(new DescribeLocationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags associated with the specified AWS Direct Connect resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualGateways


        /// <summary>
        /// Lists the virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linked to
        /// a virtual private gateway.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways()
        {
            return DescribeVirtualGateways(new DescribeVirtualGatewaysRequest());
        }


        /// <summary>
        /// Lists the virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linked to
        /// a virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Lists the virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linked to
        /// a virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualGatewaysAsync(new DescribeVirtualGatewaysRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeVirtualGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualInterfaces


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces()
        {
            return DescribeVirtualInterfaces(new DescribeVirtualInterfacesRequest());
        }


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualInterfacesResponse>(request, options);
        }


        /// <summary>
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualInterfacesAsync(new DescribeVirtualInterfacesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeVirtualInterfacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnectionFromLag


        /// <summary>
        /// Disassociates a connection from a link aggregation group (LAG). The connection is
        /// interrupted and re-established as a standalone connection (the connection is not deleted;
        /// to delete the connection, use the <a>DeleteConnection</a> request). If the LAG has
        /// associated virtual interfaces or hosted connections, they remain associated with the
        /// LAG. A disassociated connection owned by an AWS Direct Connect partner is automatically
        /// converted to an interconnect.
        /// 
        ///  
        /// <para>
        /// If disassociating the connection would cause the LAG to fall below its setting for
        /// minimum number of operational connections, the request fails, except when it's the
        /// last member of the LAG. If all connections are disassociated, the LAG continues to
        /// exist as an empty LAG with no physical connections. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnectionFromLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual DisassociateConnectionFromLagResponse DisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectionFromLagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectionFromLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual Task<DisassociateConnectionFromLagResponse> DisassociateConnectionFromLagAsync(DisassociateConnectionFromLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateConnectionFromLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified AWS Direct Connect resource. Each resource
        /// can have a maximum of 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the resource, this action updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified AWS Direct Connect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLag


        /// <summary>
        /// Updates the attributes of the specified link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// You can update the following attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value for the minimum number of connections that must be operational for the LAG
        /// itself to be operational. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you create a LAG, the default value for the minimum number of operational connections
        /// is zero (0). If you update this value and the number of operational connections falls
        /// below the specified value, the LAG automatically goes down to avoid over-utilization
        /// of the remaining connections. Adjust this value with care, as it could force the LAG
        /// down if it is set higher than the current number of operational connections.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag service method.</param>
        /// 
        /// <returns>The response from the UpdateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        public virtual UpdateLagResponse UpdateLag(UpdateLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLagResponseUnmarshaller.Instance;

            return Invoke<UpdateLagResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        public virtual Task<UpdateLagResponse> UpdateLagAsync(UpdateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLagResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVirtualInterfaceAttributes


        /// <summary>
        /// Updates the specified attributes of the specified virtual private interface.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualInterfaceAttributes service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        public virtual UpdateVirtualInterfaceAttributesResponse UpdateVirtualInterfaceAttributes(UpdateVirtualInterfaceAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVirtualInterfaceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualInterfaceAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualInterfaceAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualInterfaceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        public virtual Task<UpdateVirtualInterfaceAttributesResponse> UpdateVirtualInterfaceAttributesAsync(UpdateVirtualInterfaceAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVirtualInterfaceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualInterfaceAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVirtualInterfaceAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}