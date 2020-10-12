// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.CloudDocs
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The lock result object</para>
    /// </summary>
    public class LockResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LockResult> Encoder = new LockResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LockResult> Decoder = new LockResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockResult" /> class.</para>
        /// </summary>
        /// <param name="fileId">The file id</param>
        /// <param name="expiresAt">The timestamp after which the lock will expire, measured in
        /// seconds since 1970-01-01 00:00:00 UTC</param>
        public LockResult(string fileId = "",
                          long expiresAt = 0)
        {
            if (fileId == null)
            {
                throw new sys.ArgumentNullException("fileId");
            }

            this.FileId = fileId;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockResult" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LockResult()
        {
            this.FileId = "";
            this.ExpiresAt = 0;
        }

        /// <summary>
        /// <para>Gets the file id of the lock result</para>
        /// </summary>
        public string FileId { get; protected set; }

        /// <summary>
        /// <para>The timestamp after which the lock will expire, measured in seconds since
        /// 1970-01-01 00:00:00 UTC</para>
        /// </summary>
        public long ExpiresAt { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LockResult" />.</para>
        /// </summary>
        private class LockResultEncoder : enc.StructEncoder<LockResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LockResult value, enc.IJsonWriter writer)
            {
                WriteProperty("file_id", value.FileId, writer, enc.StringEncoder.Instance);
                WriteProperty("expires_at", value.ExpiresAt, writer, enc.Int64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LockResult" />.</para>
        /// </summary>
        private class LockResultDecoder : enc.StructDecoder<LockResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LockResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LockResult Create()
            {
                return new LockResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LockResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_id":
                        value.FileId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "expires_at":
                        value.ExpiresAt = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}