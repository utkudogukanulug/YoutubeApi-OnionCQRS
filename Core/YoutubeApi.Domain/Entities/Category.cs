﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
                
        }
        public Category(int parentId,string name,int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;

        }
        public int ParentId { get; set; }

        public string Name { get; set; }

        public required int  Priorty { get; set; }

        public ICollection<Detail> Details { get; set; }

    }
}


