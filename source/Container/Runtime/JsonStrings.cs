using System.Text.Encodings.Web;
using System.Text.Json;

namespace SharpLab.Container.Runtime {
    internal static class JsonStrings {
        // Shared
        public static readonly JsonEncodedText Name = Encode("name");
        public static readonly JsonEncodedText Value = Encode("value");

        // Inspections
        public static readonly JsonEncodedText Type = Encode("type");
        public static readonly JsonEncodedText InspectionSimple = Encode("inspection:simple");
        public static readonly JsonEncodedText InspectionMemory = Encode("inspection:memory");
        public static readonly JsonEncodedText InspectionMemoryGraph = Encode("inspection:memory-graph");
        public static readonly JsonEncodedText Title = Encode("title");
        public static readonly JsonEncodedText Labels = Encode("labels");
        public static readonly JsonEncodedText Data = Encode("data");
        public static readonly JsonEncodedText Offset = Encode("offset");
        public static readonly JsonEncodedText Length = Encode("length");
        public static readonly JsonEncodedText Nested = Encode("nested");
        public static readonly JsonEncodedText Stack = Encode("stack");
        public static readonly JsonEncodedText Heap = Encode("heap");
        public static readonly JsonEncodedText References = Encode("references");
        public static readonly JsonEncodedText Id = Encode("id");
        public static readonly JsonEncodedText Size = Encode("size");
        public static readonly JsonEncodedText NestedNodes = Encode("nestedNodes");
        public static readonly JsonEncodedText NestedNodesLimit = Encode("nestedNodesLimit");
        public static readonly JsonEncodedText From = Encode("from");
        public static readonly JsonEncodedText To = Encode("to");

        // Flow
        public static readonly JsonEncodedText Flow = Encode("flow");
        public static readonly JsonEncodedText Line = Encode("line");
        public static readonly JsonEncodedText Exception = Encode("exception");

        private static JsonEncodedText Encode(string text) => JsonEncodedText.Encode(text, JavaScriptEncoder.UnsafeRelaxedJsonEscaping);

    }
}