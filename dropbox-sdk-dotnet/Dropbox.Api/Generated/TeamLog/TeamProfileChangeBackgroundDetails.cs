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
    /// <para>Changed team background displayed on shared link headers.</para>
    /// </summary>
    public class TeamProfileChangeBackgroundDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamProfileChangeBackgroundDetails> Encoder = new TeamProfileChangeBackgroundDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamProfileChangeBackgroundDetails> Decoder = new TeamProfileChangeBackgroundDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamProfileChangeBackgroundDetails" /> class.</para>
        /// </summary>
        public TeamProfileChangeBackgroundDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamProfileChangeBackgroundDetails" />.</para>
        /// </summary>
        private class TeamProfileChangeBackgroundDetailsEncoder : enc.StructEncoder<TeamProfileChangeBackgroundDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamProfileChangeBackgroundDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamProfileChangeBackgroundDetails" />.</para>
        /// </summary>
        private class TeamProfileChangeBackgroundDetailsDecoder : enc.StructDecoder<TeamProfileChangeBackgroundDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="TeamProfileChangeBackgroundDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamProfileChangeBackgroundDetails Create()
            {
                return new TeamProfileChangeBackgroundDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamProfileChangeBackgroundDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
