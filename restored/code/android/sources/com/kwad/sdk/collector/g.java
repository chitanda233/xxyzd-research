package com.kwad.sdk.collector;

import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    public static int PERMISSION_DENIED = 2;
    public static int PERMISSION_GRANTED = 1;
    public static int aJh;
    private String aJg;
    private int state;

    public static JSONArray C(List<g> list) {
        JSONArray jSONArray = new JSONArray();
        if (list == null) {
            return jSONArray;
        }
        Iterator<g> it = list.iterator();
        while (it.hasNext()) {
            jSONArray.put(it.next().toJson());
        }
        return jSONArray;
    }

    public g(String str, int i) {
        this.aJg = str;
        this.state = i;
    }

    private JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(com.alipay.sdk.m.n.c.e, In());
            jSONObject.put("state", this.state);
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
        }
        return jSONObject;
    }

    private String In() {
        int iLastIndexOf;
        String str = this.aJg;
        if (TextUtils.isEmpty(str)) {
            return str;
        }
        return ((str.startsWith("com.android.") || str.startsWith("android.permission")) && (iLastIndexOf = str.lastIndexOf(TRouterMap.DOT)) < str.length() + (-1)) ? str.substring(iLastIndexOf + 1) : str;
    }
}
