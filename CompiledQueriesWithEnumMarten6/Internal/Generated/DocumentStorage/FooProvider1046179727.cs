// <auto-generated/>
#pragma warning disable
using CompiledQueriesWithEnumMarten6;
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
    // START: UpsertFooOperation1046179727
    public class UpsertFooOperation1046179727 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnumMarten6.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertFooOperation1046179727(CompiledQueriesWithEnumMarten6.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_foo(?, ?, ?, ?)";


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


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpsertFooOperation1046179727
    
    
    // START: InsertFooOperation1046179727
    public class InsertFooOperation1046179727 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnumMarten6.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertFooOperation1046179727(CompiledQueriesWithEnumMarten6.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_foo(?, ?, ?, ?)";


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


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: InsertFooOperation1046179727
    
    
    // START: UpdateFooOperation1046179727
    public class UpdateFooOperation1046179727 : Marten.Internal.Operations.StorageOperation<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly CompiledQueriesWithEnumMarten6.Foo _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateFooOperation1046179727(CompiledQueriesWithEnumMarten6.Foo document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_foo(?, ?, ?, ?)";


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


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpdateFooOperation1046179727
    
    
    // START: QueryOnlyFooSelector1046179727
    public class QueryOnlyFooSelector1046179727 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnumMarten6.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyFooSelector1046179727(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnumMarten6.Foo Resolve(System.Data.Common.DbDataReader reader)
        {

            CompiledQueriesWithEnumMarten6.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnumMarten6.Foo>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnumMarten6.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            CompiledQueriesWithEnumMarten6.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnumMarten6.Foo>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyFooSelector1046179727
    
    
    // START: LightweightFooSelector1046179727
    public class LightweightFooSelector1046179727 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<CompiledQueriesWithEnumMarten6.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnumMarten6.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightFooSelector1046179727(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnumMarten6.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            CompiledQueriesWithEnumMarten6.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnumMarten6.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnumMarten6.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            CompiledQueriesWithEnumMarten6.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnumMarten6.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightFooSelector1046179727
    
    
    // START: IdentityMapFooSelector1046179727
    public class IdentityMapFooSelector1046179727 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<CompiledQueriesWithEnumMarten6.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnumMarten6.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapFooSelector1046179727(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnumMarten6.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnumMarten6.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnumMarten6.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnumMarten6.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnumMarten6.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnumMarten6.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapFooSelector1046179727
    
    
    // START: DirtyTrackingFooSelector1046179727
    public class DirtyTrackingFooSelector1046179727 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<CompiledQueriesWithEnumMarten6.Foo, System.Guid>, Marten.Linq.Selectors.ISelector<CompiledQueriesWithEnumMarten6.Foo>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingFooSelector1046179727(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public CompiledQueriesWithEnumMarten6.Foo Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnumMarten6.Foo document;
            document = _serializer.FromJson<CompiledQueriesWithEnumMarten6.Foo>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<CompiledQueriesWithEnumMarten6.Foo> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            CompiledQueriesWithEnumMarten6.Foo document;
            document = await _serializer.FromJsonAsync<CompiledQueriesWithEnumMarten6.Foo>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingFooSelector1046179727
    
    
    // START: QueryOnlyFooDocumentStorage1046179727
    public class QueryOnlyFooDocumentStorage1046179727 : Marten.Internal.Storage.QueryOnlyDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyFooDocumentStorage1046179727(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnumMarten6.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnumMarten6.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyFooSelector1046179727(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyFooDocumentStorage1046179727
    
    
    // START: LightweightFooDocumentStorage1046179727
    public class LightweightFooDocumentStorage1046179727 : Marten.Internal.Storage.LightweightDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightFooDocumentStorage1046179727(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnumMarten6.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnumMarten6.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightFooSelector1046179727(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightFooDocumentStorage1046179727
    
    
    // START: IdentityMapFooDocumentStorage1046179727
    public class IdentityMapFooDocumentStorage1046179727 : Marten.Internal.Storage.IdentityMapDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapFooDocumentStorage1046179727(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnumMarten6.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnumMarten6.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapFooSelector1046179727(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapFooDocumentStorage1046179727
    
    
    // START: DirtyTrackingFooDocumentStorage1046179727
    public class DirtyTrackingFooDocumentStorage1046179727 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingFooDocumentStorage1046179727(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(CompiledQueriesWithEnumMarten6.Foo document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertFooOperation1046179727
            (
                document, Identity(document),
                session.Versions.ForType<CompiledQueriesWithEnumMarten6.Foo, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(CompiledQueriesWithEnumMarten6.Foo document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(CompiledQueriesWithEnumMarten6.Foo document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingFooSelector1046179727(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingFooDocumentStorage1046179727
    
    
    // START: FooBulkLoader1046179727
    public class FooBulkLoader1046179727 : Marten.Internal.CodeGeneration.BulkLoader<CompiledQueriesWithEnumMarten6.Foo, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid> _storage;

        public FooBulkLoader1046179727(Marten.Internal.Storage.IDocumentStorage<CompiledQueriesWithEnumMarten6.Foo, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_foo(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_foo_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_foo (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_foo_temp.\"id\", mt_doc_foo_temp.\"data\", mt_doc_foo_temp.\"mt_version\", mt_doc_foo_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_foo_temp left join public.mt_doc_foo on mt_doc_foo_temp.id = public.mt_doc_foo.id where public.mt_doc_foo.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_foo target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_foo_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_foo_temp as select * from public.mt_doc_foo limit 0";


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


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, CompiledQueriesWithEnumMarten6.Foo document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, CompiledQueriesWithEnumMarten6.Foo document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
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

    // END: FooBulkLoader1046179727
    
    
    // START: FooProvider1046179727
    public class FooProvider1046179727 : Marten.Internal.Storage.DocumentProvider<CompiledQueriesWithEnumMarten6.Foo>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public FooProvider1046179727(Marten.Schema.DocumentMapping mapping) : base(new FooBulkLoader1046179727(new QueryOnlyFooDocumentStorage1046179727(mapping)), new QueryOnlyFooDocumentStorage1046179727(mapping), new LightweightFooDocumentStorage1046179727(mapping), new IdentityMapFooDocumentStorage1046179727(mapping), new DirtyTrackingFooDocumentStorage1046179727(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: FooProvider1046179727
    
    
}

