"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./home/home.component");
var member_list_component_1 = require("./member-list/member-list.component");
var messages_component_1 = require("./messages/messages.component");
var lists_component_1 = require("./lists/lists.component");
var auth_guard_1 = require("./_guards/auth.guard");
exports.appRoutes = [
    { path: 'home', component: home_component_1.HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [auth_guard_1.AuthGuard],
        children: [
            { path: 'members', component: member_list_component_1.MemberListComponent },
            { path: 'messages', component: messages_component_1.MessagesComponent },
            { path: 'lists', component: lists_component_1.ListsComponent },
        ]
    },
    { path: '**', redirectTo: 'home', pathMatch: 'full' },
];
//# sourceMappingURL=routes.js.map