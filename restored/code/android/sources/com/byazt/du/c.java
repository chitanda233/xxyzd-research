package com.byazt.du;

import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 441, 20})
public class c {
    public static String c(String str) {
        if (TextUtils.isEmpty(str)) {
            return str;
        }
        StringBuilder sb = new StringBuilder("https://sf3-fe-tos.pglstatp-toutiao.com/obj/ad-pattern/static/images/");
        if (str.indexOf(TRouterMap.DOT) > 0) {
            return sb.append(str).toString();
        }
        return sb.append(str).append(".png").toString();
    }
}
