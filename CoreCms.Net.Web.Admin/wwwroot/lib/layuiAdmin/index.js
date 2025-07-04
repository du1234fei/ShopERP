/** layuiAdmin.pro-v1.7.0 LPPL License */
;
layui.extend({
	setter: "config",
	admin: "lib/admin",
	view: "lib/view",
	breadcrumb: 'controller/breadcrumb'
}).define(["setter", "admin", "breadcrumb"],
	function (e) {
		var a = layui.setter,
			n = layui.element,
			i = layui.admin,
			t = i.tabsPage,
			l = layui.view,
			r = function () {
				var e = layui.router(),
					o = e.path,
					y = i.correctRouter(e.path.join("/"));
				o.length || (o = [""]),
					"" === o[o.length - 1] && (o[o.length - 1] = a.entry);
				var h = function (e) {
					r.haveInit && d(".layui-layer").each(function () {
						var e = d(this),
							a = e.attr("times");
						e.hasClass("layui-layim") || layer.close(a)
					}),
						r.haveInit = !0,
						d(s).scrollTop(0),
						delete t.type
				};
				return "tab" === t.type && ("/" !== y || "/" === y && i.tabsBody().html()) ? (i.tabsBodyChange(t.index), h(t.type)) : (l().render(o.join("/")).then(function (l) {
					var r, o = d("#LAY_app_tabsheader>li");
					o.each(function (e) {
						var a = d(this),
							n = a.attr("lay-id");
						n === y && (r = !0, t.index = e)
					}),
						a.pageTabs && "/" !== y && (r || (d(s).append('<div class="layadmin-tabsbody-item layui-show"></div>'), t.index = o.length, n.tabAdd(u, {
							title: "<span>" + (l.title || "新标签页") + "</span>",
							id: y,
							attr: e.href
						}))),
						this.container = i.tabsBody(t.index),
						a.pageTabs || this.container.scrollTop(0),
						n.tabChange(u, y),
						i.tabsBodyChange(t.index)
				}).done(function () {
					layui.use("common", layui.cache.callback.common),
						c.on("resize", layui.data.resize),
						n.render("breadcrumb", "breadcrumb"),
						i.tabsBody(t.index).on("scroll",
							function () {
								var e = d(this),
									a = d(".layui-laydate"),
									n = d(".layui-layer")[0];
								a[0] && (a.each(function () {
									var e = d(this);
									e.hasClass("layui-laydate-static") || e.remove()
								}), e.find("input").blur()),
									n && layer.closeAll("tips")
							})
				}), void h())
			},
			o = function (e) {
				var n, t = layui.router(),
					o = l(a.container),
					s = i.correctRouter(t.path.join("/"));
				if (layui.each(a.indPage,
					function (e, a) {
						if (s === a) return n = !0
					}), layui.config({
						base: a.base + "controller/"
					}), n || "/user/login" === s) o.render(t.path.join("/")).done(function () {
						i.pageType = "alone"
					});
				else {
					if (a.interceptor) {
						var u = layui.data(a.tableName);
						if (!u[a.request.tokenName]) return location.hash = "/user/login/redirect=" + encodeURIComponent(s)
					}
					"console" === i.pageType ? r() : o.render("layout").done(function () {
						r(),
							layui.element.render(),
							i.screen() < 2 && i.sideFlexible(),
							i.pageType = "console"
					})
				}
			},
			s = "#LAY_app_body",
			u = "layadmin-layout-tabs",
			d = layui.$,
			c = d(window);
		layui.link(a.base + "style/admin.css?v=" + (i.v + "-1"),
			function () {
				o()
			},
			"layuiAdmin"),
			window.onhashchange = function () {
				o(),
					layui.event.call(this, a.MOD_NAME, "hash({*})", layui.router())
			},
			layui.each(a.extend,
				function (e, n) {
					var i = {},
						t = a.extend.constructor === Array;
					i[t ? n : e] = "{/}" + a.base + "lib/extend/" + n,
						layui.extend(i)
				}),
			e("index", {
				render: r
			})
	});