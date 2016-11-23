﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovITHub.Auth.Admin.Models
{
    public class ModelQuery<T>
    {
        public IEnumerable<T> List { get; set; }
        public int TotalItems { get; set; }
    }

    public class ModelQueryFilter
    {
        public int CurrentPage { get; set; } = 0;
        public int ItemsPerPage { get; set; } = 10;
        public string SortBy { get; set; }
        public bool SortAscending { get; set; } = true;

        public ModelQueryFilter() { }
        public ModelQueryFilter(int currentPage, int itemsPerPage, bool sortAscending, string sortBy)
        {
            if (currentPage > 0)
                CurrentPage = currentPage - 1;

            if (itemsPerPage > 0)
                ItemsPerPage = itemsPerPage;

            if (!string.IsNullOrEmpty(sortBy))
            {
                SortBy = sortBy.ToTitleCase();
                SortAscending = sortAscending;
            }
        }
    }
}
