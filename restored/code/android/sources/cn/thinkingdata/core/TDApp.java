package cn.thinkingdata.core;

import android.content.Context;
import cn.thinkingdata.core.router.TRouter;
import cn.thinkingdata.core.router.TRouterMap;
import cn.thinkingdata.core.utils.TDCommonUtil;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
public class TDApp {
    public static void init(Context context) {
        if (context == null) {
            return;
        }
        init(context, TDCommonUtil.getConfigFromAssets(context));
    }

    public static void init(Context context, TDSettings tDSettings) {
        if (context == null || tDSettings == null) {
            return;
        }
        ArrayList arrayList = new ArrayList();
        arrayList.add(tDSettings);
        init(context, arrayList);
    }

    public static void init(Context context, List<TDSettings> list) {
        if (context == null || list == null) {
            return;
        }
        TRouter.init();
        try {
            TRouter.getInstance().build(TRouterMap.ANALYTIC_ROUTE_PATH).withAction("init").withObject("context", context).withObject("settings", list).navigation();
            TRouter.getInstance().build(TRouterMap.RCC_PLUGIN_ROUTE_PATH).withAction("init").withObject("context", context).withObject("settings", list).navigation();
            TRouter.getInstance().build(TRouterMap.STRATEGY_PLUGIN_ROUTE_PATH).withAction("init").withObject("context", context).withObject("settings", list).navigation();
        } catch (Exception unused) {
        }
    }
}
