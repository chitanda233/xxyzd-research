package com.kwad.sdk.core.videocache.a;

import android.net.Uri;
import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import com.kwad.sdk.utils.an;
import java.util.HashMap;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class f implements c {
    @Override // com.kwad.sdk.core.videocache.a.c
    public final String generate(String str) {
        String strFD = fD(str);
        String extension = getExtension(strFD);
        String strMd5 = an.md5(strFD);
        return TextUtils.isEmpty(extension) ? strMd5 : strMd5 + TRouterMap.DOT + extension;
    }

    private static String getExtension(String str) {
        int iLastIndexOf = str.lastIndexOf(46);
        return (iLastIndexOf == -1 || iLastIndexOf <= str.lastIndexOf(47) || (iLastIndexOf + 2) + 4 <= str.length()) ? "" : str.substring(iLastIndexOf + 1, str.length());
    }

    private static String fD(String str) {
        if (!str.startsWith("http://") && !str.startsWith("https://")) {
            return str;
        }
        Uri uri = Uri.parse(str);
        if (uri.getHost() == null || !uri.getHost().endsWith(".yximgs.com")) {
            return str;
        }
        Uri.Builder builderBuildUpon = uri.buildUpon();
        HashMap map = new HashMap();
        if (uri.isHierarchical()) {
            Set<String> queryParameterNames = uri.getQueryParameterNames();
            for (String str2 : queryParameterNames) {
                map.put(str2, uri.getQueryParameter(str2));
            }
            builderBuildUpon.clearQuery();
            for (String str3 : queryParameterNames) {
                if (!"tag".equals(str3) && !"di".equals(str3) && str3 != null) {
                    builderBuildUpon.appendQueryParameter(str3, (String) map.get(str3));
                }
            }
        }
        return builderBuildUpon.toString();
    }
}
