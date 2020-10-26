﻿// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System.Collections.Generic;
using BookApp.ServiceLayer.DefaultSql.Books;

namespace BookApp.ServiceLayer.UtfsSql.Books.Dtos
{
    public class UtfsBookListCombinedDto
    {
        public UtfsBookListCombinedDto(SortFilterPageOptions sortFilterPageData, IEnumerable<UtfsBookListDto> booksList)
        {
            SortFilterPageData = sortFilterPageData;
            BooksList = booksList;
        }

        public SortFilterPageOptions SortFilterPageData { get; private set; }

        public IEnumerable<UtfsBookListDto> BooksList { get; private set; }
    }
}