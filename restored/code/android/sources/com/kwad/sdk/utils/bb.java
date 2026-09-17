package com.kwad.sdk.utils;

import java.util.Iterator;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class bb {
    public static String appendUrl(String str, Map<String, String> map) {
        String str2;
        if (map == null || map.size() <= 0) {
            return str;
        }
        StringBuilder sb = new StringBuilder();
        Iterator<String> it = map.keySet().iterator();
        while (true) {
            boolean zHasNext = it.hasNext();
            str2 = com.alipay.sdk.m.w.a.p;
            if (!zHasNext) {
                break;
            }
            String next = it.next();
            if (map.get(next) != null) {
                sb.append(next).append("=").append(map.get(next)).append(com.alipay.sdk.m.w.a.p);
            }
        }
        String string = sb.toString();
        String strSubstring = string.substring(0, string.length() - 1);
        StringBuilder sbAppend = new StringBuilder().append(str);
        if (!str.contains("?")) {
            str2 = "?";
        }
        return sbAppend.append(str2).toString() + strSubstring;
    }
}
