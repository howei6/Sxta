using System;
using System.IO;
using System.Collections.Generic;

using Mogre;

using Hla.Rti1516;
using Sxta.Rti1516.Serializers.XrtiEncoding;
using Sxta.Rti1516.Reflection;
using Sxta.Rti1516.Interactions;

namespace Sxta.Rti1516.BoidSample
{

    ///<summary>
    ///Autogenerated Serializer Helper. Serializes and deserializes Boid.Color
    ///parameters into and from HLA formats. 
    ///</summary>
    /// <author> Sxta.Rti1516.DynamicCompiler.DynamicCompiler from Boids Object Model </author>
    public class BoidPropertyColorXrtiSerializer : BaseInteractionMessageXrtiSerializer
    {
        ///<summary>Constructor for the serializer of Boid.Color property.
        /// </summary>
        public BoidPropertyColorXrtiSerializer(XrtiSerializerManager manager)
            : base(manager)
        {
        }

        ///<summary>
        /// Writes this Boid.Color to the specified stream.
        ///</summary>
        ///<param name="writer"> the output stream to write to</param>
        ///<param name="Color"> the property to serialize</param>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override void Serialize(HlaEncodingWriter writer, object Color)
        {
            try
            {
                writer.WriteHLAunicodeString((String)Color);
            }
            catch (IOException ioe)
            {
                throw new RTIinternalError(ioe.ToString());
            }

        }

        ///<summary>
        /// Reads and returns a Boid.Color from the specified stream.
        ///</summary>
        ///<param name="reader"> the input stream to read from</param>
        ///<param name="dummy"> this parameter is not used</param>
        ///<returns> the decoded value</returns>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override object Deserialize(HlaEncodingReader reader, ref object dummy)
        {
            String decodedValue;
            try
            {
                decodedValue = reader.ReadHLAunicodeString();
                return decodedValue;
            }
            catch (IOException ioe)
            {
                throw new FederateInternalError(ioe.ToString());
            }
        }
    }


    ///<summary>
    ///Autogenerated Serializer Helper. Serializes and deserializes Boid.Position
    ///parameters into and from HLA formats. 
    ///</summary>
    /// <author> Sxta1516.DynamicCompiler.DynamicCompiler from Hello World Object Model </author>
    public class BoidPropertyPositionXrtiSerializer : BaseInteractionMessageXrtiSerializer
    {
        ///<summary>Constructor for the serializer of Boid.Position property.
        /// </summary>
        public BoidPropertyPositionXrtiSerializer(XrtiSerializerManager manager)
            : base(manager)
        {
        }

        ///<summary>
        /// Writes this Boid.Position to the specified stream.
        ///</summary>
        ///<param name="writer"> the output stream to write to</param>
        ///<param name="Position"> the property to serialize</param>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override void Serialize(HlaEncodingWriter writer, object Position)
        {
            try
            {
                Vector3XrtiSerializer.Serialize(writer, (Vector3)Position);
            }
            catch (IOException ioe)
            {
                throw new RTIinternalError(ioe.ToString());
            }

        }

        ///<summary>
        /// Reads and returns a Boid.Position from the specified stream.
        ///</summary>
        ///<param name="reader"> the input stream to read from</param>
        ///<param name="dummy"> this parameter is not used</param>
        ///<returns> the decoded value</returns>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override object Deserialize(HlaEncodingReader reader, ref object dummy)
        {
            Vector3 decodedValue;
            try
            {
                decodedValue = Vector3XrtiSerializer.Deserialize(reader);
                return decodedValue;
            }
            catch (IOException ioe)
            {
                throw new FederateInternalError(ioe.ToString());
            }
        }
    }

    ///<summary>
    ///Autogenerated Serializer Helper. Serializes and deserializes Boid.Velocity
    ///parameters into and from HLA formats. 
    ///</summary>
    /// <author> Sxta1516.DynamicCompiler.DynamicCompiler from Hello World Object Model </author>
    public class BoidPropertyVelocityXrtiSerializer : BaseInteractionMessageXrtiSerializer
    {
        ///<summary>Constructor for the serializer of Boid.Velocity property.
        /// </summary>
        public BoidPropertyVelocityXrtiSerializer(XrtiSerializerManager manager)
            : base(manager)
        {
        }

        ///<summary>
        /// Writes this Boid.Velocity to the specified stream.
        ///</summary>
        ///<param name="writer"> the output stream to write to</param>
        ///<param name="Velocity"> the property to serialize</param>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override void Serialize(HlaEncodingWriter writer, object Velocity)
        {
            try
            {
                Vector3XrtiSerializer.Serialize(writer, (Vector3)Velocity);
            }
            catch (IOException ioe)
            {
                throw new RTIinternalError(ioe.ToString());
            }

        }

        ///<summary>
        /// Reads and returns a Boid.Velocity from the specified stream.
        ///</summary>
        ///<param name="reader"> the input stream to read from</param>
        ///<param name="dummy"> this parameter is not used</param>
        ///<returns> the decoded value</returns>
        ///<exception cref="System.IO.IOException"> if an error occurs</exception>
        public override object Deserialize(HlaEncodingReader reader, ref object dummy)
        {
            Vector3 decodedValue;
            try
            {
                decodedValue = Vector3XrtiSerializer.Deserialize(reader);
                return decodedValue;
            }
            catch (IOException ioe)
            {
                throw new FederateInternalError(ioe.ToString());
            }
        }
    }
}