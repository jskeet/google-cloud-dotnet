// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981

namespace Google.Cloud.Storage.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gcsv = Google.Cloud.Storage.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageClientSnippets
    {
        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucketRequestObject()
        {
            // Snippet: DeleteBucket(DeleteBucketRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            DeleteBucketRequest request = new DeleteBucketRequest
            {
                BucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            storageClient.DeleteBucket(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketRequestObjectAsync()
        {
            // Snippet: DeleteBucketAsync(DeleteBucketRequest, CallSettings)
            // Additional: DeleteBucketAsync(DeleteBucketRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBucketRequest request = new DeleteBucketRequest
            {
                BucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
            };
            // Make the request
            await storageClient.DeleteBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucket()
        {
            // Snippet: DeleteBucket(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            storageClient.DeleteBucket(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketAsync()
        {
            // Snippet: DeleteBucketAsync(string, CallSettings)
            // Additional: DeleteBucketAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            await storageClient.DeleteBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucket</summary>
        public void DeleteBucketResourceNames()
        {
            // Snippet: DeleteBucket(BucketName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            storageClient.DeleteBucket(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBucketAsync</summary>
        public async Task DeleteBucketResourceNamesAsync()
        {
            // Snippet: DeleteBucketAsync(BucketName, CallSettings)
            // Additional: DeleteBucketAsync(BucketName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            await storageClient.DeleteBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketRequestObject()
        {
            // Snippet: GetBucket(GetBucketRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                BucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ReadMask = new FieldMask(),
            };
            // Make the request
            Bucket response = storageClient.GetBucket(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketRequestObjectAsync()
        {
            // Snippet: GetBucketAsync(GetBucketRequest, CallSettings)
            // Additional: GetBucketAsync(GetBucketRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                BucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                ReadMask = new FieldMask(),
            };
            // Make the request
            Bucket response = await storageClient.GetBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucket()
        {
            // Snippet: GetBucket(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            Bucket response = storageClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketAsync()
        {
            // Snippet: GetBucketAsync(string, CallSettings)
            // Additional: GetBucketAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            Bucket response = await storageClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucketResourceNames()
        {
            // Snippet: GetBucket(BucketName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            Bucket response = storageClient.GetBucket(name);
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketResourceNamesAsync()
        {
            // Snippet: GetBucketAsync(BucketName, CallSettings)
            // Additional: GetBucketAsync(BucketName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName name = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            Bucket response = await storageClient.GetBucketAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketRequestObject()
        {
            // Snippet: CreateBucket(CreateBucketRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Bucket = new Bucket(),
                BucketId = "",
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            Bucket response = storageClient.CreateBucket(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketRequestObjectAsync()
        {
            // Snippet: CreateBucketAsync(CreateBucketRequest, CallSettings)
            // Additional: CreateBucketAsync(CreateBucketRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Bucket = new Bucket(),
                BucketId = "",
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            Bucket response = await storageClient.CreateBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucket()
        {
            // Snippet: CreateBucket(string, Bucket, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Bucket response = storageClient.CreateBucket(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketAsync()
        {
            // Snippet: CreateBucketAsync(string, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(string, Bucket, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Bucket response = await storageClient.CreateBucketAsync(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucket</summary>
        public void CreateBucketResourceNames()
        {
            // Snippet: CreateBucket(ProjectName, Bucket, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Bucket response = storageClient.CreateBucket(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for CreateBucketAsync</summary>
        public async Task CreateBucketResourceNamesAsync()
        {
            // Snippet: CreateBucketAsync(ProjectName, Bucket, string, CallSettings)
            // Additional: CreateBucketAsync(ProjectName, Bucket, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Bucket bucket = new Bucket();
            string bucketId = "";
            // Make the request
            Bucket response = await storageClient.CreateBucketAsync(parent, bucket, bucketId);
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBucketsRequestObject()
        {
            // Snippet: ListBuckets(ListBucketsRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Prefix = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBuckets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsRequestObjectAsync()
        {
            // Snippet: ListBucketsAsync(ListBucketsRequest, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Prefix = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBucketsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBuckets()
        {
            // Snippet: ListBuckets(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsAsync()
        {
            // Snippet: ListBucketsAsync(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBucketsResourceNames()
        {
            // Snippet: ListBuckets(ProjectName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Bucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsResourceNamesAsync()
        {
            // Snippet: ListBucketsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, Bucket> response = storageClient.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Bucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Bucket item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Bucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Bucket item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicyRequestObject()
        {
            // Snippet: LockBucketRetentionPolicy(LockBucketRetentionPolicyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            LockBucketRetentionPolicyRequest request = new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
            };
            // Make the request
            Bucket response = storageClient.LockBucketRetentionPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyRequestObjectAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(LockBucketRetentionPolicyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            LockBucketRetentionPolicyRequest request = new LockBucketRetentionPolicyRequest
            {
                BucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                IfMetagenerationMatch = 0L,
            };
            // Make the request
            Bucket response = await storageClient.LockBucketRetentionPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicy()
        {
            // Snippet: LockBucketRetentionPolicy(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            Bucket response = storageClient.LockBucketRetentionPolicy(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(string, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            Bucket response = await storageClient.LockBucketRetentionPolicyAsync(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicy</summary>
        public void LockBucketRetentionPolicyResourceNames()
        {
            // Snippet: LockBucketRetentionPolicy(BucketName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName bucket = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            Bucket response = storageClient.LockBucketRetentionPolicy(bucket);
            // End snippet
        }

        /// <summary>Snippet for LockBucketRetentionPolicyAsync</summary>
        public async Task LockBucketRetentionPolicyResourceNamesAsync()
        {
            // Snippet: LockBucketRetentionPolicyAsync(BucketName, CallSettings)
            // Additional: LockBucketRetentionPolicyAsync(BucketName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName bucket = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            Bucket response = await storageClient.LockBucketRetentionPolicyAsync(bucket);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = storageClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = storageClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = storageClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await storageClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = storageClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = storageClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = storageClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await storageClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = storageClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await storageClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucketRequestObject()
        {
            // Snippet: UpdateBucket(UpdateBucketRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                Bucket = new Bucket(),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            Bucket response = storageClient.UpdateBucket(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketRequestObjectAsync()
        {
            // Snippet: UpdateBucketAsync(UpdateBucketRequest, CallSettings)
            // Additional: UpdateBucketAsync(UpdateBucketRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                Bucket = new Bucket(),
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                PredefinedAcl = "",
                PredefinedDefaultObjectAcl = "",
            };
            // Make the request
            Bucket response = await storageClient.UpdateBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucket()
        {
            // Snippet: UpdateBucket(Bucket, FieldMask, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            Bucket bucket = new Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Bucket response = storageClient.UpdateBucket(bucket, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketAsync()
        {
            // Snippet: UpdateBucketAsync(Bucket, FieldMask, CallSettings)
            // Additional: UpdateBucketAsync(Bucket, FieldMask, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            Bucket bucket = new Bucket();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Bucket response = await storageClient.UpdateBucketAsync(bucket, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotification</summary>
        public void DeleteNotificationRequestObject()
        {
            // Snippet: DeleteNotification(DeleteNotificationRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            DeleteNotificationRequest request = new DeleteNotificationRequest
            {
                NotificationName = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]"),
            };
            // Make the request
            storageClient.DeleteNotification(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationAsync</summary>
        public async Task DeleteNotificationRequestObjectAsync()
        {
            // Snippet: DeleteNotificationAsync(DeleteNotificationRequest, CallSettings)
            // Additional: DeleteNotificationAsync(DeleteNotificationRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNotificationRequest request = new DeleteNotificationRequest
            {
                NotificationName = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]"),
            };
            // Make the request
            await storageClient.DeleteNotificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotification</summary>
        public void DeleteNotification()
        {
            // Snippet: DeleteNotification(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/notificationConfigs/[NOTIFICATION]";
            // Make the request
            storageClient.DeleteNotification(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationAsync</summary>
        public async Task DeleteNotificationAsync()
        {
            // Snippet: DeleteNotificationAsync(string, CallSettings)
            // Additional: DeleteNotificationAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/notificationConfigs/[NOTIFICATION]";
            // Make the request
            await storageClient.DeleteNotificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotification</summary>
        public void DeleteNotificationResourceNames()
        {
            // Snippet: DeleteNotification(NotificationName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]");
            // Make the request
            storageClient.DeleteNotification(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNotificationAsync</summary>
        public async Task DeleteNotificationResourceNamesAsync()
        {
            // Snippet: DeleteNotificationAsync(NotificationName, CallSettings)
            // Additional: DeleteNotificationAsync(NotificationName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]");
            // Make the request
            await storageClient.DeleteNotificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotificationRequestObject()
        {
            // Snippet: GetNotification(GetNotificationRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetNotificationRequest request = new GetNotificationRequest
            {
                NotificationName = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]"),
            };
            // Make the request
            Notification response = storageClient.GetNotification(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationRequestObjectAsync()
        {
            // Snippet: GetNotificationAsync(GetNotificationRequest, CallSettings)
            // Additional: GetNotificationAsync(GetNotificationRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetNotificationRequest request = new GetNotificationRequest
            {
                NotificationName = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]"),
            };
            // Make the request
            Notification response = await storageClient.GetNotificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotification()
        {
            // Snippet: GetNotification(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/notificationConfigs/[NOTIFICATION]";
            // Make the request
            Notification response = storageClient.GetNotification(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationAsync()
        {
            // Snippet: GetNotificationAsync(string, CallSettings)
            // Additional: GetNotificationAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/buckets/[BUCKET]/notificationConfigs/[NOTIFICATION]";
            // Make the request
            Notification response = await storageClient.GetNotificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotification</summary>
        public void GetNotificationResourceNames()
        {
            // Snippet: GetNotification(NotificationName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]");
            // Make the request
            Notification response = storageClient.GetNotification(name);
            // End snippet
        }

        /// <summary>Snippet for GetNotificationAsync</summary>
        public async Task GetNotificationResourceNamesAsync()
        {
            // Snippet: GetNotificationAsync(NotificationName, CallSettings)
            // Additional: GetNotificationAsync(NotificationName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            NotificationName name = NotificationName.FromProjectBucketNotification("[PROJECT]", "[BUCKET]", "[NOTIFICATION]");
            // Make the request
            Notification response = await storageClient.GetNotificationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNotification</summary>
        public void CreateNotificationRequestObject()
        {
            // Snippet: CreateNotification(CreateNotificationRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            CreateNotificationRequest request = new CreateNotificationRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Notification = new Notification(),
            };
            // Make the request
            Notification response = storageClient.CreateNotification(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationAsync</summary>
        public async Task CreateNotificationRequestObjectAsync()
        {
            // Snippet: CreateNotificationAsync(CreateNotificationRequest, CallSettings)
            // Additional: CreateNotificationAsync(CreateNotificationRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            CreateNotificationRequest request = new CreateNotificationRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Notification = new Notification(),
            };
            // Make the request
            Notification response = await storageClient.CreateNotificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNotification</summary>
        public void CreateNotification()
        {
            // Snippet: CreateNotification(string, Notification, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            Notification notification = new Notification();
            // Make the request
            Notification response = storageClient.CreateNotification(parent, notification);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationAsync</summary>
        public async Task CreateNotificationAsync()
        {
            // Snippet: CreateNotificationAsync(string, Notification, CallSettings)
            // Additional: CreateNotificationAsync(string, Notification, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            Notification notification = new Notification();
            // Make the request
            Notification response = await storageClient.CreateNotificationAsync(parent, notification);
            // End snippet
        }

        /// <summary>Snippet for CreateNotification</summary>
        public void CreateNotificationResourceNames()
        {
            // Snippet: CreateNotification(BucketName, Notification, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            Notification notification = new Notification();
            // Make the request
            Notification response = storageClient.CreateNotification(parent, notification);
            // End snippet
        }

        /// <summary>Snippet for CreateNotificationAsync</summary>
        public async Task CreateNotificationResourceNamesAsync()
        {
            // Snippet: CreateNotificationAsync(BucketName, Notification, CallSettings)
            // Additional: CreateNotificationAsync(BucketName, Notification, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            Notification notification = new Notification();
            // Make the request
            Notification response = await storageClient.CreateNotificationAsync(parent, notification);
            // End snippet
        }

        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotificationsRequestObject()
        {
            // Snippet: ListNotifications(ListNotificationsRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ListNotificationsRequest request = new ListNotificationsRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
            };
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotifications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsRequestObjectAsync()
        {
            // Snippet: ListNotificationsAsync(ListNotificationsRequest, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ListNotificationsRequest request = new ListNotificationsRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotificationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotifications()
        {
            // Snippet: ListNotifications(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotifications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsAsync()
        {
            // Snippet: ListNotificationsAsync(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotificationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotifications</summary>
        public void ListNotificationsResourceNames()
        {
            // Snippet: ListNotifications(BucketName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotifications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Notification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotificationsAsync</summary>
        public async Task ListNotificationsResourceNamesAsync()
        {
            // Snippet: ListNotificationsAsync(BucketName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListNotificationsResponse, Notification> response = storageClient.ListNotificationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Notification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Notification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Notification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Notification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ComposeObject</summary>
        public void ComposeObjectRequestObject()
        {
            // Snippet: ComposeObject(ComposeObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ComposeObjectRequest request = new ComposeObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceObjects =
                {
                    new ComposeObjectRequest.Types.SourceObject(),
                },
                IfGenerationMatch = 0L,
                IfMetagenerationMatch = 0L,
                KmsKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            gcsv::Object response = storageClient.ComposeObject(request);
            // End snippet
        }

        /// <summary>Snippet for ComposeObjectAsync</summary>
        public async Task ComposeObjectRequestObjectAsync()
        {
            // Snippet: ComposeObjectAsync(ComposeObjectRequest, CallSettings)
            // Additional: ComposeObjectAsync(ComposeObjectRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ComposeObjectRequest request = new ComposeObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceObjects =
                {
                    new ComposeObjectRequest.Types.SourceObject(),
                },
                IfGenerationMatch = 0L,
                IfMetagenerationMatch = 0L,
                KmsKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            gcsv::Object response = await storageClient.ComposeObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObjectRequestObject()
        {
            // Snippet: DeleteObject(DeleteObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            DeleteObjectRequest request = new DeleteObjectRequest
            {
                Bucket = "",
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
            };
            // Make the request
            storageClient.DeleteObject(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObjectRequestObjectAsync()
        {
            // Snippet: DeleteObjectAsync(DeleteObjectRequest, CallSettings)
            // Additional: DeleteObjectAsync(DeleteObjectRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteObjectRequest request = new DeleteObjectRequest
            {
                Bucket = "",
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
            };
            // Make the request
            await storageClient.DeleteObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject1()
        {
            // Snippet: DeleteObject(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            // Make the request
            storageClient.DeleteObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject1Async()
        {
            // Snippet: DeleteObjectAsync(string, string, CallSettings)
            // Additional: DeleteObjectAsync(string, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for DeleteObject</summary>
        public void DeleteObject2()
        {
            // Snippet: DeleteObject(string, string, long, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            long generation = 0L;
            // Make the request
            storageClient.DeleteObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for DeleteObjectAsync</summary>
        public async Task DeleteObject2Async()
        {
            // Snippet: DeleteObjectAsync(string, string, long, CallSettings)
            // Additional: DeleteObjectAsync(string, string, long, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            long generation = 0L;
            // Make the request
            await storageClient.DeleteObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWrite</summary>
        public void CancelResumableWriteRequestObject()
        {
            // Snippet: CancelResumableWrite(CancelResumableWriteRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            CancelResumableWriteRequest request = new CancelResumableWriteRequest { UploadId = "", };
            // Make the request
            CancelResumableWriteResponse response = storageClient.CancelResumableWrite(request);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWriteAsync</summary>
        public async Task CancelResumableWriteRequestObjectAsync()
        {
            // Snippet: CancelResumableWriteAsync(CancelResumableWriteRequest, CallSettings)
            // Additional: CancelResumableWriteAsync(CancelResumableWriteRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            CancelResumableWriteRequest request = new CancelResumableWriteRequest { UploadId = "", };
            // Make the request
            CancelResumableWriteResponse response = await storageClient.CancelResumableWriteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWrite</summary>
        public void CancelResumableWrite()
        {
            // Snippet: CancelResumableWrite(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            CancelResumableWriteResponse response = storageClient.CancelResumableWrite(uploadId);
            // End snippet
        }

        /// <summary>Snippet for CancelResumableWriteAsync</summary>
        public async Task CancelResumableWriteAsync()
        {
            // Snippet: CancelResumableWriteAsync(string, CallSettings)
            // Additional: CancelResumableWriteAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            CancelResumableWriteResponse response = await storageClient.CancelResumableWriteAsync(uploadId);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObjectRequestObject()
        {
            // Snippet: GetObject(GetObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetObjectRequest request = new GetObjectRequest
            {
                Bucket = "",
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
            };
            // Make the request
            gcsv::Object response = storageClient.GetObject(request);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObjectRequestObjectAsync()
        {
            // Snippet: GetObjectAsync(GetObjectRequest, CallSettings)
            // Additional: GetObjectAsync(GetObjectRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetObjectRequest request = new GetObjectRequest
            {
                Bucket = "",
                Object = "",
                Generation = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
            };
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject1()
        {
            // Snippet: GetObject(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject1Async()
        {
            // Snippet: GetObjectAsync(string, string, CallSettings)
            // Additional: GetObjectAsync(string, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object);
            // End snippet
        }

        /// <summary>Snippet for GetObject</summary>
        public void GetObject2()
        {
            // Snippet: GetObject(string, string, long, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = storageClient.GetObject(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for GetObjectAsync</summary>
        public async Task GetObject2Async()
        {
            // Snippet: GetObjectAsync(string, string, long, CallSettings)
            // Additional: GetObjectAsync(string, string, long, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            long generation = 0L;
            // Make the request
            gcsv::Object response = await storageClient.GetObjectAsync(bucket, @object, generation);
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObjectRequestObject()
        {
            // Snippet: ReadObject(ReadObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ReadObjectRequest request = new ReadObjectRequest
            {
                Bucket = "",
                Object = "",
                Generation = 0L,
                ReadOffset = 0L,
                ReadLimit = 0L,
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ReadMask = new FieldMask(),
            };
            // Make the request, returning a streaming response
            StorageClient.ReadObjectStream response = storageClient.ReadObject(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject1()
        {
            // Snippet: ReadObject(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            // Make the request, returning a streaming response
            StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadObject</summary>
        public async Task ReadObject2()
        {
            // Snippet: ReadObject(string, string, long, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string bucket = "";
            string @object = "";
            long generation = 0L;
            // Make the request, returning a streaming response
            StorageClient.ReadObjectStream response = storageClient.ReadObject(bucket, @object, generation);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadObjectResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadObjectResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for UpdateObject</summary>
        public void UpdateObjectRequestObject()
        {
            // Snippet: UpdateObject(UpdateObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            UpdateObjectRequest request = new UpdateObjectRequest
            {
                Object = new gcsv::Object(),
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                PredefinedAcl = "",
            };
            // Make the request
            gcsv::Object response = storageClient.UpdateObject(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateObjectAsync</summary>
        public async Task UpdateObjectRequestObjectAsync()
        {
            // Snippet: UpdateObjectAsync(UpdateObjectRequest, CallSettings)
            // Additional: UpdateObjectAsync(UpdateObjectRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateObjectRequest request = new UpdateObjectRequest
            {
                Object = new gcsv::Object(),
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                UpdateMask = new FieldMask(),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                PredefinedAcl = "",
            };
            // Make the request
            gcsv::Object response = await storageClient.UpdateObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateObject</summary>
        public void UpdateObject()
        {
            // Snippet: UpdateObject(Object, FieldMask, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            gcsv::Object @object = new gcsv::Object();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Object response = storageClient.UpdateObject(@object, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateObjectAsync</summary>
        public async Task UpdateObjectAsync()
        {
            // Snippet: UpdateObjectAsync(Object, FieldMask, CallSettings)
            // Additional: UpdateObjectAsync(Object, FieldMask, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::Object @object = new gcsv::Object();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcsv::Object response = await storageClient.UpdateObjectAsync(@object, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjectsRequestObject()
        {
            // Snippet: ListObjects(ListObjectsRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ListObjectsRequest request = new ListObjectsRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Delimiter = "",
                IncludeTrailingDelimiter = false,
                Prefix = "",
                Versions = false,
                ReadMask = new FieldMask(),
                LexicographicStart = "",
                LexicographicEnd = "",
            };
            // Make the request
            PagedEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsRequestObjectAsync()
        {
            // Snippet: ListObjectsAsync(ListObjectsRequest, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ListObjectsRequest request = new ListObjectsRequest
            {
                ParentAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                Delimiter = "",
                IncludeTrailingDelimiter = false,
                Prefix = "",
                Versions = false,
                ReadMask = new FieldMask(),
                LexicographicStart = "",
                LexicographicEnd = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjects()
        {
            // Snippet: ListObjects(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsAsync()
        {
            // Snippet: ListObjectsAsync(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/buckets/[BUCKET]";
            // Make the request
            PagedAsyncEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjects</summary>
        public void ListObjectsResourceNames()
        {
            // Snippet: ListObjects(BucketName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Object item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListObjectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListObjectsAsync</summary>
        public async Task ListObjectsResourceNamesAsync()
        {
            // Snippet: ListObjectsAsync(BucketName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            BucketName parent = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]");
            // Make the request
            PagedAsyncEnumerable<ListObjectsResponse, gcsv::Object> response = storageClient.ListObjectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Object item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListObjectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Object item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Object> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Object item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RewriteObject</summary>
        public void RewriteObjectRequestObject()
        {
            // Snippet: RewriteObject(RewriteObjectRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            RewriteObjectRequest request = new RewriteObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceBucket = "",
                SourceObject = "",
                SourceGeneration = 0L,
                RewriteToken = "",
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                MaxBytesRewrittenPerCall = 0L,
                CopySourceEncryptionAlgorithm = "",
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                CopySourceEncryptionKeyBytes = ByteString.Empty,
                CopySourceEncryptionKeySha256Bytes = ByteString.Empty,
                DestinationName = "",
                DestinationBucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                DestinationKmsKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            RewriteResponse response = storageClient.RewriteObject(request);
            // End snippet
        }

        /// <summary>Snippet for RewriteObjectAsync</summary>
        public async Task RewriteObjectRequestObjectAsync()
        {
            // Snippet: RewriteObjectAsync(RewriteObjectRequest, CallSettings)
            // Additional: RewriteObjectAsync(RewriteObjectRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            RewriteObjectRequest request = new RewriteObjectRequest
            {
                Destination = new gcsv::Object(),
                SourceBucket = "",
                SourceObject = "",
                SourceGeneration = 0L,
                RewriteToken = "",
                IfGenerationMatch = 0L,
                IfGenerationNotMatch = 0L,
                IfMetagenerationMatch = 0L,
                IfMetagenerationNotMatch = 0L,
                IfSourceGenerationMatch = 0L,
                IfSourceGenerationNotMatch = 0L,
                IfSourceMetagenerationMatch = 0L,
                IfSourceMetagenerationNotMatch = 0L,
                MaxBytesRewrittenPerCall = 0L,
                CopySourceEncryptionAlgorithm = "",
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                CopySourceEncryptionKeyBytes = ByteString.Empty,
                CopySourceEncryptionKeySha256Bytes = ByteString.Empty,
                DestinationName = "",
                DestinationBucketAsBucketName = BucketName.FromProjectBucket("[PROJECT]", "[BUCKET]"),
                DestinationKmsKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                DestinationPredefinedAcl = "",
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            RewriteResponse response = await storageClient.RewriteObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartResumableWrite</summary>
        public void StartResumableWriteRequestObject()
        {
            // Snippet: StartResumableWrite(StartResumableWriteRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            StartResumableWriteRequest request = new StartResumableWriteRequest
            {
                WriteObjectSpec = new WriteObjectSpec(),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            StartResumableWriteResponse response = storageClient.StartResumableWrite(request);
            // End snippet
        }

        /// <summary>Snippet for StartResumableWriteAsync</summary>
        public async Task StartResumableWriteRequestObjectAsync()
        {
            // Snippet: StartResumableWriteAsync(StartResumableWriteRequest, CallSettings)
            // Additional: StartResumableWriteAsync(StartResumableWriteRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            StartResumableWriteRequest request = new StartResumableWriteRequest
            {
                WriteObjectSpec = new WriteObjectSpec(),
                CommonObjectRequestParams = new CommonObjectRequestParams(),
                ObjectChecksums = new ObjectChecksums(),
            };
            // Make the request
            StartResumableWriteResponse response = await storageClient.StartResumableWriteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatus</summary>
        public void QueryWriteStatusRequestObject()
        {
            // Snippet: QueryWriteStatus(QueryWriteStatusRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            QueryWriteStatusRequest request = new QueryWriteStatusRequest
            {
                UploadId = "",
                CommonObjectRequestParams = new CommonObjectRequestParams(),
            };
            // Make the request
            QueryWriteStatusResponse response = storageClient.QueryWriteStatus(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatusAsync</summary>
        public async Task QueryWriteStatusRequestObjectAsync()
        {
            // Snippet: QueryWriteStatusAsync(QueryWriteStatusRequest, CallSettings)
            // Additional: QueryWriteStatusAsync(QueryWriteStatusRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            QueryWriteStatusRequest request = new QueryWriteStatusRequest
            {
                UploadId = "",
                CommonObjectRequestParams = new CommonObjectRequestParams(),
            };
            // Make the request
            QueryWriteStatusResponse response = await storageClient.QueryWriteStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatus</summary>
        public void QueryWriteStatus()
        {
            // Snippet: QueryWriteStatus(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            QueryWriteStatusResponse response = storageClient.QueryWriteStatus(uploadId);
            // End snippet
        }

        /// <summary>Snippet for QueryWriteStatusAsync</summary>
        public async Task QueryWriteStatusAsync()
        {
            // Snippet: QueryWriteStatusAsync(string, CallSettings)
            // Additional: QueryWriteStatusAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string uploadId = "";
            // Make the request
            QueryWriteStatusResponse response = await storageClient.QueryWriteStatusAsync(uploadId);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountRequestObject()
        {
            // Snippet: GetServiceAccount(GetServiceAccountRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ServiceAccount response = storageClient.GetServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountRequestObjectAsync()
        {
            // Snippet: GetServiceAccountAsync(GetServiceAccountRequest, CallSettings)
            // Additional: GetServiceAccountAsync(GetServiceAccountRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ServiceAccount response = await storageClient.GetServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccount()
        {
            // Snippet: GetServiceAccount(string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            ServiceAccount response = storageClient.GetServiceAccount(project);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountAsync()
        {
            // Snippet: GetServiceAccountAsync(string, CallSettings)
            // Additional: GetServiceAccountAsync(string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            ServiceAccount response = await storageClient.GetServiceAccountAsync(project);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountResourceNames()
        {
            // Snippet: GetServiceAccount(ProjectName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ServiceAccount response = storageClient.GetServiceAccount(project);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountResourceNamesAsync()
        {
            // Snippet: GetServiceAccountAsync(ProjectName, CallSettings)
            // Additional: GetServiceAccountAsync(ProjectName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ServiceAccount response = await storageClient.GetServiceAccountAsync(project);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKey</summary>
        public void CreateHmacKeyRequestObject()
        {
            // Snippet: CreateHmacKey(CreateHmacKeyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            CreateHmacKeyRequest request = new CreateHmacKeyRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "",
            };
            // Make the request
            CreateHmacKeyResponse response = storageClient.CreateHmacKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKeyAsync</summary>
        public async Task CreateHmacKeyRequestObjectAsync()
        {
            // Snippet: CreateHmacKeyAsync(CreateHmacKeyRequest, CallSettings)
            // Additional: CreateHmacKeyAsync(CreateHmacKeyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            CreateHmacKeyRequest request = new CreateHmacKeyRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "",
            };
            // Make the request
            CreateHmacKeyResponse response = await storageClient.CreateHmacKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKey</summary>
        public void CreateHmacKey()
        {
            // Snippet: CreateHmacKey(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            string serviceAccountEmail = "";
            // Make the request
            CreateHmacKeyResponse response = storageClient.CreateHmacKey(project, serviceAccountEmail);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKeyAsync</summary>
        public async Task CreateHmacKeyAsync()
        {
            // Snippet: CreateHmacKeyAsync(string, string, CallSettings)
            // Additional: CreateHmacKeyAsync(string, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            string serviceAccountEmail = "";
            // Make the request
            CreateHmacKeyResponse response = await storageClient.CreateHmacKeyAsync(project, serviceAccountEmail);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKey</summary>
        public void CreateHmacKeyResourceNames()
        {
            // Snippet: CreateHmacKey(ProjectName, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            string serviceAccountEmail = "";
            // Make the request
            CreateHmacKeyResponse response = storageClient.CreateHmacKey(project, serviceAccountEmail);
            // End snippet
        }

        /// <summary>Snippet for CreateHmacKeyAsync</summary>
        public async Task CreateHmacKeyResourceNamesAsync()
        {
            // Snippet: CreateHmacKeyAsync(ProjectName, string, CallSettings)
            // Additional: CreateHmacKeyAsync(ProjectName, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            string serviceAccountEmail = "";
            // Make the request
            CreateHmacKeyResponse response = await storageClient.CreateHmacKeyAsync(project, serviceAccountEmail);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKey</summary>
        public void DeleteHmacKeyRequestObject()
        {
            // Snippet: DeleteHmacKey(DeleteHmacKeyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            DeleteHmacKeyRequest request = new DeleteHmacKeyRequest
            {
                AccessId = "",
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            storageClient.DeleteHmacKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKeyAsync</summary>
        public async Task DeleteHmacKeyRequestObjectAsync()
        {
            // Snippet: DeleteHmacKeyAsync(DeleteHmacKeyRequest, CallSettings)
            // Additional: DeleteHmacKeyAsync(DeleteHmacKeyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHmacKeyRequest request = new DeleteHmacKeyRequest
            {
                AccessId = "",
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            await storageClient.DeleteHmacKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKey</summary>
        public void DeleteHmacKey()
        {
            // Snippet: DeleteHmacKey(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string accessId = "";
            string project = "projects/[PROJECT]";
            // Make the request
            storageClient.DeleteHmacKey(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKeyAsync</summary>
        public async Task DeleteHmacKeyAsync()
        {
            // Snippet: DeleteHmacKeyAsync(string, string, CallSettings)
            // Additional: DeleteHmacKeyAsync(string, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string accessId = "";
            string project = "projects/[PROJECT]";
            // Make the request
            await storageClient.DeleteHmacKeyAsync(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKey</summary>
        public void DeleteHmacKeyResourceNames()
        {
            // Snippet: DeleteHmacKey(string, ProjectName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string accessId = "";
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            storageClient.DeleteHmacKey(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for DeleteHmacKeyAsync</summary>
        public async Task DeleteHmacKeyResourceNamesAsync()
        {
            // Snippet: DeleteHmacKeyAsync(string, ProjectName, CallSettings)
            // Additional: DeleteHmacKeyAsync(string, ProjectName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string accessId = "";
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            await storageClient.DeleteHmacKeyAsync(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKey</summary>
        public void GetHmacKeyRequestObject()
        {
            // Snippet: GetHmacKey(GetHmacKeyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            GetHmacKeyRequest request = new GetHmacKeyRequest
            {
                AccessId = "",
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            HmacKeyMetadata response = storageClient.GetHmacKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKeyAsync</summary>
        public async Task GetHmacKeyRequestObjectAsync()
        {
            // Snippet: GetHmacKeyAsync(GetHmacKeyRequest, CallSettings)
            // Additional: GetHmacKeyAsync(GetHmacKeyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            GetHmacKeyRequest request = new GetHmacKeyRequest
            {
                AccessId = "",
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            HmacKeyMetadata response = await storageClient.GetHmacKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKey</summary>
        public void GetHmacKey()
        {
            // Snippet: GetHmacKey(string, string, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string accessId = "";
            string project = "projects/[PROJECT]";
            // Make the request
            HmacKeyMetadata response = storageClient.GetHmacKey(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKeyAsync</summary>
        public async Task GetHmacKeyAsync()
        {
            // Snippet: GetHmacKeyAsync(string, string, CallSettings)
            // Additional: GetHmacKeyAsync(string, string, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string accessId = "";
            string project = "projects/[PROJECT]";
            // Make the request
            HmacKeyMetadata response = await storageClient.GetHmacKeyAsync(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKey</summary>
        public void GetHmacKeyResourceNames()
        {
            // Snippet: GetHmacKey(string, ProjectName, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string accessId = "";
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            HmacKeyMetadata response = storageClient.GetHmacKey(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for GetHmacKeyAsync</summary>
        public async Task GetHmacKeyResourceNamesAsync()
        {
            // Snippet: GetHmacKeyAsync(string, ProjectName, CallSettings)
            // Additional: GetHmacKeyAsync(string, ProjectName, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string accessId = "";
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            HmacKeyMetadata response = await storageClient.GetHmacKeyAsync(accessId, project);
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeys</summary>
        public void ListHmacKeysRequestObject()
        {
            // Snippet: ListHmacKeys(ListHmacKeysRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ListHmacKeysRequest request = new ListHmacKeysRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "",
                ShowDeletedKeys = false,
            };
            // Make the request
            PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HmacKeyMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHmacKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeysAsync</summary>
        public async Task ListHmacKeysRequestObjectAsync()
        {
            // Snippet: ListHmacKeysAsync(ListHmacKeysRequest, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ListHmacKeysRequest request = new ListHmacKeysRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ServiceAccountEmail = "",
                ShowDeletedKeys = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HmacKeyMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHmacKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeys</summary>
        public void ListHmacKeys()
        {
            // Snippet: ListHmacKeys(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeys(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HmacKeyMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHmacKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeysAsync</summary>
        public async Task ListHmacKeysAsync()
        {
            // Snippet: ListHmacKeysAsync(string, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeysAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HmacKeyMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHmacKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeys</summary>
        public void ListHmacKeysResourceNames()
        {
            // Snippet: ListHmacKeys(ProjectName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeys(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HmacKeyMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHmacKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHmacKeysAsync</summary>
        public async Task ListHmacKeysResourceNamesAsync()
        {
            // Snippet: ListHmacKeysAsync(ProjectName, string, int?, CallSettings)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListHmacKeysResponse, HmacKeyMetadata> response = storageClient.ListHmacKeysAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HmacKeyMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHmacKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HmacKeyMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HmacKeyMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HmacKeyMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateHmacKey</summary>
        public void UpdateHmacKeyRequestObject()
        {
            // Snippet: UpdateHmacKey(UpdateHmacKeyRequest, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            UpdateHmacKeyRequest request = new UpdateHmacKeyRequest
            {
                HmacKey = new HmacKeyMetadata(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            HmacKeyMetadata response = storageClient.UpdateHmacKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHmacKeyAsync</summary>
        public async Task UpdateHmacKeyRequestObjectAsync()
        {
            // Snippet: UpdateHmacKeyAsync(UpdateHmacKeyRequest, CallSettings)
            // Additional: UpdateHmacKeyAsync(UpdateHmacKeyRequest, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHmacKeyRequest request = new UpdateHmacKeyRequest
            {
                HmacKey = new HmacKeyMetadata(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            HmacKeyMetadata response = await storageClient.UpdateHmacKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHmacKey</summary>
        public void UpdateHmacKey()
        {
            // Snippet: UpdateHmacKey(HmacKeyMetadata, FieldMask, CallSettings)
            // Create client
            StorageClient storageClient = StorageClient.Create();
            // Initialize request argument(s)
            HmacKeyMetadata hmacKey = new HmacKeyMetadata();
            FieldMask updateMask = new FieldMask();
            // Make the request
            HmacKeyMetadata response = storageClient.UpdateHmacKey(hmacKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateHmacKeyAsync</summary>
        public async Task UpdateHmacKeyAsync()
        {
            // Snippet: UpdateHmacKeyAsync(HmacKeyMetadata, FieldMask, CallSettings)
            // Additional: UpdateHmacKeyAsync(HmacKeyMetadata, FieldMask, CancellationToken)
            // Create client
            StorageClient storageClient = await StorageClient.CreateAsync();
            // Initialize request argument(s)
            HmacKeyMetadata hmacKey = new HmacKeyMetadata();
            FieldMask updateMask = new FieldMask();
            // Make the request
            HmacKeyMetadata response = await storageClient.UpdateHmacKeyAsync(hmacKey, updateMask);
            // End snippet
        }
    }
}
