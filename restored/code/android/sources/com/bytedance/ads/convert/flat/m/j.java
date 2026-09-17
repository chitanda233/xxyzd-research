package com.bytedance.ads.convert.flat.m;

import android.content.ContentProviderClient;
import android.content.Context;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.text.TextUtils;
import com.byazt.nys.PluginConstants;

/* JADX INFO: loaded from: classes2.dex */
public final class j implements com.bytedance.ads.convert.flat.k.c {
    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        try {
            ContentProviderClient contentProviderClientAcquireContentProviderClient = context.getContentResolver().acquireContentProviderClient(Uri.parse("content://cn.nubia.identity/identity"));
            if (contentProviderClientAcquireContentProviderClient == null) {
                return null;
            }
            Bundle bundleCall = contentProviderClientAcquireContentProviderClient.call("getOAID", null, null);
            contentProviderClientAcquireContentProviderClient.close();
            if (bundleCall == null) {
                return null;
            }
            if (bundleCall.getInt(PluginConstants.KEY_ERROR_CODE, -1) == 0) {
                com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
                aVar.f1727a = bundleCall.getString("id");
                return aVar;
            }
            String string = bundleCall.getString("message");
            if (!TextUtils.isEmpty(string)) {
                String str = "Nubia bundle mes error: " + string;
            }
            return null;
        } catch (Exception e) {
            String str2 = "Nubia getOaid error: " + e.getMessage();
            return null;
        }
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        return Build.VERSION.SDK_INT > 28;
    }
}
