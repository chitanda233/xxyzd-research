package com.unicom.online.account.kernel;

import com.alipay.sdk.m.w.a;
import java.util.Iterator;
import java.util.Map;
import java.util.TreeMap;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class aj {
    public static String b(String str) {
        if (str == null || str.trim().isEmpty()) {
            return "";
        }
        TreeMap treeMap = new TreeMap();
        if (!str.trim().isEmpty()) {
            try {
                JSONObject jSONObject = new JSONObject(str);
                Iterator<String> itKeys = jSONObject.keys();
                while (itKeys.hasNext()) {
                    String next = itKeys.next();
                    treeMap.put(next, jSONObject.get(next));
                }
            } catch (Exception e) {
                as.b(e);
            }
        }
        StringBuilder sb = new StringBuilder();
        boolean z = true;
        for (Map.Entry entry : treeMap.entrySet()) {
            String str2 = (String) entry.getKey();
            Object value = entry.getValue();
            if (str2 != null && !str2.trim().isEmpty()) {
                if (!z) {
                    sb.append(a.p);
                }
                StringBuilder sbAppend = sb.append(str2).append("=");
                if (value == null) {
                    value = "";
                }
                sbAppend.append(value);
                z = false;
            }
        }
        return sb.toString();
    }
}
