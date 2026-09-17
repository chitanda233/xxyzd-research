package com.sigmob.sdk.videocache.file;

import android.text.TextUtils;
import cn.thinkingdata.core.router.TRouterMap;
import com.sigmob.sdk.videocache.q;

/* JADX INFO: loaded from: classes4.dex */
public class f implements c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3664a = 4;

    private String b(String url) {
        int iLastIndexOf = url.lastIndexOf(46);
        return (iLastIndexOf == -1 || iLastIndexOf <= url.lastIndexOf(47) || (iLastIndexOf + 2) + 4 <= url.length()) ? "" : url.substring(iLastIndexOf + 1, url.length());
    }

    @Override // com.sigmob.sdk.videocache.file.c
    public String a(String url) {
        String strB = b(url);
        String strD = q.d(url);
        return TextUtils.isEmpty(strB) ? strD : strD + TRouterMap.DOT + strB;
    }
}
