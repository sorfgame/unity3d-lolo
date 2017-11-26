--
-- 框架中用到的常量
-- 2017/11/7
-- Author LOLO
--


---@class Constants
local Constants = {

    -- 场景图层
    LAYER_SCENE = "sceneLayer", ---@type string @ 场景层
    LAYER_UI = "uiLayer", ---@type string @ UI层
    LAYER_WINDOW = "windowLayer", ---@type string @ 窗口层
    LAYER_UI_TOP = "uiTopLayer", ---@type string @ 顶级UI层
    LAYER_ALERT = "alertLayer", ---@type string @ 提示层
    LAYER_GUIDE = "guideLayer", ---@type string @ 引导层
    LAYER_TOP = "topLayer", ---@type string @ 顶级层


    -- 错误信息
    E1001 = "不存在的图层：%s",
    E1002 = "必须设定场景名称（moduleName）。className：%s",
    E1003 = "参数错误！参数 prefab 为 预设路径，请传入 groupName 参数，指定资源组名称。prefab：%s",
    E1004 = "View 只能被初始化一次。className：%s",
    E1005 = "View 还未被初始化。className：%s",

    E2001 = "无法解析JSON字符串：%s",
    E2002 = "不能将table转换成JSON字符串：%s",



}


return Constants