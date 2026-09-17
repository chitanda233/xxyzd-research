package com.cmic.gen.sdk.e;

import android.content.ContentProviderClient;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import com.byazt.nys.PluginConstants;

/* JADX INFO: compiled from: NubiaOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class h extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2108a;

    h(Context context) {
        this.f2108a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        try {
            ContentProviderClient contentProviderClientAcquireContentProviderClient = this.f2108a.getContentResolver().acquireContentProviderClient(Uri.parse("content://cn.nubia.identity/identity"));
            Bundle bundleCall = null;
            if (contentProviderClientAcquireContentProviderClient != null) {
                bundleCall = contentProviderClientAcquireContentProviderClient.call("getOAID", null, null);
                contentProviderClientAcquireContentProviderClient.close();
            }
            return (bundleCall != null ? bundleCall.getInt(PluginConstants.KEY_ERROR_CODE, -1) : -1) == 0 ? bundleCall.getString("id") : "";
        } catch (Exception unused) {
            return "";
        }
    }
}
