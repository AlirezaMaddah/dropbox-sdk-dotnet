// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The unlock file batch arg object</para>
    /// </summary>
    public class UnlockFileBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UnlockFileBatchArg> Encoder = new UnlockFileBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UnlockFileBatchArg> Decoder = new UnlockFileBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UnlockFileBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">List of 'entries'. Each 'entry' contains a path of the file
        /// which will be unlocked. Duplicate path arguments in the batch are considered only
        /// once.</param>
        public UnlockFileBatchArg(col.IEnumerable<UnlockFileArg> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UnlockFileBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UnlockFileBatchArg()
        {
        }

        /// <summary>
        /// <para>List of 'entries'. Each 'entry' contains a path of the file which will be
        /// unlocked. Duplicate path arguments in the batch are considered only once.</para>
        /// </summary>
        public col.IList<UnlockFileArg> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UnlockFileBatchArg" />.</para>
        /// </summary>
        private class UnlockFileBatchArgEncoder : enc.StructEncoder<UnlockFileBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UnlockFileBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, global::Dropbox.Api.Files.UnlockFileArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UnlockFileBatchArg" />.</para>
        /// </summary>
        private class UnlockFileBatchArgDecoder : enc.StructDecoder<UnlockFileBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UnlockFileBatchArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UnlockFileBatchArg Create()
            {
                return new UnlockFileBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UnlockFileBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<UnlockFileArg>(reader, global::Dropbox.Api.Files.UnlockFileArg.Decoder);
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