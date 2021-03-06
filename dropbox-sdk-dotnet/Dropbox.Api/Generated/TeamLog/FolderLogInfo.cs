// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Folder's logged information.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.TeamLog.FileOrFolderLogInfo" />
    public class FolderLogInfo : FileOrFolderLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderLogInfo> Encoder = new FolderLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderLogInfo> Decoder = new FolderLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderLogInfo" /> class.</para>
        /// </summary>
        /// <param name="path">Path relative to event context.</param>
        /// <param name="displayName">Display name.</param>
        /// <param name="fileId">Unique ID.</param>
        /// <param name="fileSize">File or folder size in bytes.</param>
        /// <param name="fileCount">Number of files within the folder.</param>
        public FolderLogInfo(PathLogInfo path,
                             string displayName = null,
                             string fileId = null,
                             ulong? fileSize = null,
                             ulong? fileCount = null)
            : base(path, displayName, fileId, fileSize)
        {
            this.FileCount = fileCount;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderLogInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FolderLogInfo()
        {
        }

        /// <summary>
        /// <para>Number of files within the folder.</para>
        /// </summary>
        public ulong? FileCount { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderLogInfo" />.</para>
        /// </summary>
        private class FolderLogInfoEncoder : enc.StructEncoder<FolderLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, global::Dropbox.Api.TeamLog.PathLogInfo.Encoder);
                if (value.DisplayName != null)
                {
                    WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                }
                if (value.FileId != null)
                {
                    WriteProperty("file_id", value.FileId, writer, enc.StringEncoder.Instance);
                }
                if (value.FileSize != null)
                {
                    WriteProperty("file_size", value.FileSize.Value, writer, enc.UInt64Encoder.Instance);
                }
                if (value.FileCount != null)
                {
                    WriteProperty("file_count", value.FileCount.Value, writer, enc.UInt64Encoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderLogInfo" />.</para>
        /// </summary>
        private class FolderLogInfoDecoder : enc.StructDecoder<FolderLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderLogInfo Create()
            {
                return new FolderLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FolderLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = global::Dropbox.Api.TeamLog.PathLogInfo.Decoder.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "file_id":
                        value.FileId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "file_size":
                        value.FileSize = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "file_count":
                        value.FileCount = enc.UInt64Decoder.Instance.Decode(reader);
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
