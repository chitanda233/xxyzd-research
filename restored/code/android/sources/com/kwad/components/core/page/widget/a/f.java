package com.kwad.components.core.page.widget.a;

import android.net.Uri;
import android.text.TextUtils;
import com.kwad.components.core.t.r;
import com.kwad.components.core.t.u;

/* JADX INFO: loaded from: classes3.dex */
public final class f implements g {
    @Override // com.kwad.components.core.page.widget.a.g
    public final e ba(String str) {
        e eVar = new e();
        if (TextUtils.isEmpty(str)) {
            return eVar;
        }
        Uri uri = Uri.parse(str);
        eVar.ahA = r.a(u.a(uri, "heightRatio", "0"), 0.0f);
        eVar.ahB = r.a(u.a(uri, "absoluteHeight", "0"), 0.0f);
        eVar.ahD = r.m(u.a(uri, "topRadius", "0"), 0);
        eVar.ahC = r.a(u.a(uri, "maskAlpha", "0"), 0.0f);
        eVar.ahE = bb(u.a(uri, "disableClickOutsideDismiss", "false"));
        eVar.ahF = bb(u.a(uri, "enableDragHalfToFull", "false"));
        eVar.ahG = bb(u.a(uri, "showStatusBar", "false"));
        eVar.ahI = bb(u.a(uri, "isAdjustKeyBoard", "true"));
        eVar.ahK = u.a(uri);
        return eVar;
    }

    private static boolean bb(String str) {
        if (TextUtils.isEmpty(str)) {
            return false;
        }
        try {
            return Boolean.parseBoolean(str);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return false;
        }
    }
}
