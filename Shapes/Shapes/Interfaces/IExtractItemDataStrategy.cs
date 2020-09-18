using Shapes.Models;
using System.Collections.Generic;

namespace Shapes.Interfaces
{
    public interface IExtractItemDataStrategy
    {
        IEnumerable<Item> GetAllDeserializedItems();
    }
}