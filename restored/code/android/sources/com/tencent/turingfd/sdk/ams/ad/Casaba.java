package com.tencent.turingfd.sdk.ams.ad;

import android.content.ContentProviderClient;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;

/* JADX INFO: loaded from: classes4.dex */
public final class Casaba implements Equuleus {
    /* JADX WARN: Code duplicated, block: B:11:0x002d  */
    /* JADX WARN: Code duplicated, block: B:13:0x003a  */
    /* JADX WARN: Code duplicated, block: B:15:0x0040  */
    /* JADX WARN: Code duplicated, block: B:9:0x0027  */
    @Override // com.tencent.turingfd.sdk.ams.ad.Equuleus
    public final Bryony a(Context context) {
        Uri uri = Uri.parse(Cinstanceof.a(Cinstanceof.v0));
        String strA = Cinstanceof.a(Cinstanceof.f3938a);
        ContentProviderClient contentProviderClientAcquireContentProviderClient = context.getContentResolver().acquireContentProviderClient(uri);
        Bundle bundleCall = null;
        try {
            bundleCall = contentProviderClientAcquireContentProviderClient.call(strA, null, null);
        } catch (Throwable unused) {
            if (contentProviderClientAcquireContentProviderClient != null) {
            }
            if (bundleCall == null) {
                return new Bryony("");
            }
            return bundleCall.getInt(Cinstanceof.a(Cinstanceof.w0), -1) != 0 ? new Bryony("") : new Bryony(bundleCall.getString(Cinstanceof.a(Cinstanceof.x0)));
        }
        contentProviderClientAcquireContentProviderClient.close();
        if (bundleCall == null) {
            return new Bryony("");
        }
        if (bundleCall.getInt(Cinstanceof.a(Cinstanceof.w0), -1) != 0) {
        }
    }
}
