// <auto-generated/>
#pragma warning disable
using CompiledQueriesWithEnums;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertFooOperation1344638247
    public class UpsertFooOperation1344638247 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnums.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertFooOperation1344638247(CompiledQueriesWithEnums.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }



        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Weasel.Postgresql.IGroupedParameterBuilder parameterBuilder, Weasel.Postgresql.ICommandBuilder builder, CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session)
        {
            builder.Append("select public.mt_upsert_foo(");
            var parameter0 = parameterBuilder.AppendParameter(session.Serializer.ToJson(_document));
            parameter0.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            // .Net Class Type
            var parameter1 = parameterBuilder.AppendParameter(_document.GetType().FullName);
            parameter1.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            var parameter2 = parameterBuilder.AppendParameter(document.Id);
            setVersionParameter(parameterBuilder);
            builder.Append(')');
        }

    }

    // END: UpsertFooOperation1344638247
    
    
    // START: InsertFooOperation1344638247
    public class InsertFooOperation1344638247 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnums.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertFooOperation1344638247(CompiledQueriesWithEnums.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }



        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Weasel.Postgresql.IGroupedParameterBuilder parameterBuilder, Weasel.Postgresql.ICommandBuilder builder, CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session)
        {
            builder.Append("select public.mt_insert_foo(");
            var parameter0 = parameterBuilder.AppendParameter(session.Serializer.ToJson(_document));
            parameter0.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            // .Net Class Type
            var parameter1 = parameterBuilder.AppendParameter(_document.GetType().FullName);
            parameter1.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            var parameter2 = parameterBuilder.AppendParameter(document.Id);
            setVersionParameter(parameterBuilder);
            builder.Append(')');
        }

    }

    // END: InsertFooOperation1344638247
    
    
    // START: UpdateFooOperation1344638247
    public class UpdateFooOperation1344638247 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnums.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateFooOperation1344638247(CompiledQueriesWithEnums.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }



        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Weasel.Postgresql.IGroupedParameterBuilder parameterBuilder, Weasel.Postgresql.ICommandBuilder builder, CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session)
        {
            builder.Append("select public.mt_update_foo(");
            var parameter0 = parameterBuilder.AppendParameter(session.Serializer.ToJson(_document));
            parameter0.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            // .Net Class Type
            var parameter1 = parameterBuilder.AppendParameter(_document.GetType().FullName);
            parameter1.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            var parameter2 = parameterBuilder.AppendParameter(document.Id);
            setVersionParameter(parameterBuilder);
            builder.Append(')');
        }

    }

    // END: UpdateFooOperation1344638247
    
    
    // START: QueryOnlyFooSelector1344638247
    public class QueryOnlyFooSelector1344638247 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnums.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyFooSelector1344638247(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnums.Foo Resolve(System.Data.Common.DbDataReader reader)
        {

            CompiledQueriesWithEnums.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnums.Foo>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnums.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            CompiledQueriesWithEnums.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnums.Foo>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyFooSelector1344638247
    
    
    // START: LightweightFooSelector1344638247
    public class LightweightFooSelector1344638247 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<CompiledQueriesWithEnums.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnums.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightFooSelector1344638247(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnums.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            CompiledQueriesWithEnums.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnums.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnums.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            CompiledQueriesWithEnums.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnums.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightFooSelector1344638247
    
    
    // START: IdentityMapFooSelector1344638247
    public class IdentityMapFooSelector1344638247 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<CompiledQueriesWithEnums.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnums.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapFooSelector1344638247(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnums.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnums.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnums.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnums.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnums.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnums.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapFooSelector1344638247
    
    
    // START: DirtyTrackingFooSelector1344638247
    public class DirtyTrackingFooSelector1344638247 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<CompiledQueriesWithEnums.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnums.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingFooSelector1344638247(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnums.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnums.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnums.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnums.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnums.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnums.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingFooSelector1344638247
    
    
    // START: QueryOnlyFooDocumentStorage1344638247
    public class QueryOnlyFooDocumentStorage1344638247 : Marten.Internal.Storage.QueryOnlyDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyFooDocumentStorage1344638247(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnums.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnums.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyFooSelector1344638247(session, _document);
        }


        public override object RawIdentityValue(System.Guid id)
        {
            return id;
        }


        public override Npgsql.NpgsqlParameter BuildManyIdParameter(System.Guid[] ids)
        {
            return base.BuildManyIdParameter(ids);
        }

    }

    // END: QueryOnlyFooDocumentStorage1344638247
    
    
    // START: LightweightFooDocumentStorage1344638247
    public class LightweightFooDocumentStorage1344638247 : Marten.Internal.Storage.LightweightDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightFooDocumentStorage1344638247(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnums.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnums.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightFooSelector1344638247(session, _document);
        }


        public override object RawIdentityValue(System.Guid id)
        {
            return id;
        }


        public override Npgsql.NpgsqlParameter BuildManyIdParameter(System.Guid[] ids)
        {
            return base.BuildManyIdParameter(ids);
        }

    }

    // END: LightweightFooDocumentStorage1344638247
    
    
    // START: IdentityMapFooDocumentStorage1344638247
    public class IdentityMapFooDocumentStorage1344638247 : Marten.Internal.Storage.IdentityMapDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapFooDocumentStorage1344638247(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnums.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnums.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapFooSelector1344638247(session, _document);
        }


        public override object RawIdentityValue(System.Guid id)
        {
            return id;
        }


        public override Npgsql.NpgsqlParameter BuildManyIdParameter(System.Guid[] ids)
        {
            return base.BuildManyIdParameter(ids);
        }

    }

    // END: IdentityMapFooDocumentStorage1344638247
    
    
    // START: DirtyTrackingFooDocumentStorage1344638247
    public class DirtyTrackingFooDocumentStorage1344638247 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingFooDocumentStorage1344638247(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnums.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1344638247
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnums.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnums.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnums.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingFooSelector1344638247(session, _document);
        }


        public override object RawIdentityValue(System.Guid id)
        {
            return id;
        }


        public override Npgsql.NpgsqlParameter BuildManyIdParameter(System.Guid[] ids)
        {
            return base.BuildManyIdParameter(ids);
        }

    }

    // END: DirtyTrackingFooDocumentStorage1344638247
    
    
    // START: FooBulkLoader1344638247
    public class FooBulkLoader1344638247 : Marten.Internal.CodeGeneration.BulkLoader<CompiledQueriesWithEnums.Foo, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid> _storage;

        public FooBulkLoader1344638247(Marten.Internal.Storage.IDocumentStorage<CompiledQueriesWithEnums.Foo, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_foo(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_foo_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_foo (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_foo_temp.\"id\", mt_doc_foo_temp.\"data\", mt_doc_foo_temp.\"mt_version\", mt_doc_foo_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_foo_temp left join public.mt_doc_foo on mt_doc_foo_temp.id = public.mt_doc_foo.id where public.mt_doc_foo.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_foo target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_foo_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_foo_temp (like public.mt_doc_foo including defaults)";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, CompiledQueriesWithEnums.Foo document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, CompiledQueriesWithEnums.Foo document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: FooBulkLoader1344638247
    
    
    // START: FooProvider1344638247
    public class FooProvider1344638247 : Marten.Internal.Storage.DocumentProvider<CompiledQueriesWithEnums.Foo>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public FooProvider1344638247(Marten.Schema.DocumentMapping mapping) : base(new FooBulkLoader1344638247(new QueryOnlyFooDocumentStorage1344638247(mapping)), new QueryOnlyFooDocumentStorage1344638247(mapping), new LightweightFooDocumentStorage1344638247(mapping), new IdentityMapFooDocumentStorage1344638247(mapping), new DirtyTrackingFooDocumentStorage1344638247(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: FooProvider1344638247
    
    
}
