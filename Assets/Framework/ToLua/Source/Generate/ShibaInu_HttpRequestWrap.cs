﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ShibaInu_HttpRequestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ShibaInu.HttpRequest), typeof(System.Object));
		L.RegFunction("AppedPostData", AppedPostData);
		L.RegFunction("CleanPostData", CleanPostData);
		L.RegFunction("SetProxy", SetProxy);
		L.RegFunction("SetLuaCallback", SetLuaCallback);
		L.RegFunction("Send", Send);
		L.RegFunction("Abort", Abort);
		L.RegFunction("New", _CreateShibaInu_HttpRequest);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("url", get_url, set_url);
		L.RegVar("method", get_method, set_method);
		L.RegVar("timeout", get_timeout, set_timeout);
		L.RegVar("postData", get_postData, set_postData);
		L.RegVar("callback", get_callback, set_callback);
		L.RegVar("requeting", get_requeting, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateShibaInu_HttpRequest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ShibaInu.HttpRequest obj = new ShibaInu.HttpRequest();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ShibaInu.HttpRequest.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppedPostData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.AppedPostData(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CleanPostData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			obj.CleanPostData();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetProxy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SetProxy(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLuaCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 2);
			obj.SetLuaCallback(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Send(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			obj.Send();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Abort(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)ToLua.CheckObject<ShibaInu.HttpRequest>(L, 1);
			obj.Abort();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_url(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string ret = obj.url;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index url on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_method(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string ret = obj.method;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index method on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			int ret = obj.timeout;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_postData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string ret = obj.postData;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index postData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_callback(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			System.Action<int,string> ret = obj.callback;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index callback on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_requeting(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			bool ret = obj.requeting;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index requeting on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_url(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.url = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index url on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_method(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.method = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index method on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_timeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.timeout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index timeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_postData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.postData = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index postData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_callback(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ShibaInu.HttpRequest obj = (ShibaInu.HttpRequest)o;
			System.Action<int,string> arg0 = (System.Action<int,string>)ToLua.CheckDelegate<System.Action<int,string>>(L, 2);
			obj.callback = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index callback on a nil value");
		}
	}
}
