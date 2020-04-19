﻿using MediatR;

namespace Blog.Handlers.Users
{
    public class GetUsersByFilterRequest : IRequest<GetUsersByFilterResult>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string? UserNameFilter { get; set; }

        public string? UserEmailFilter { get; set; }
        
        public int? RoleIdFilter { get; set; }
    }
}