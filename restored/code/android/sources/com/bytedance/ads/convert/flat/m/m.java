package com.bytedance.ads.convert.flat.m;

import android.content.ContentProviderClient;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes2.dex */
public class m implements com.bytedance.ads.convert.flat.k.c {

    public static class a extends com.bytedance.ads.convert.flat.k.c.a {
    }

    /* JADX WARN: Code duplicated, block: B:16:0x0029 A[PHI: r2 r4
  0x0029: PHI (r2v3 android.os.Bundle) = (r2v2 android.os.Bundle), (r2v9 android.os.Bundle) binds: [B:15:0x0027, B:5:0x001a] A[DONT_GENERATE, DONT_INLINE]
  0x0029: PHI (r4v4 android.content.ContentProviderClient) = (r4v15 android.content.ContentProviderClient), (r4v16 android.content.ContentProviderClient) binds: [B:15:0x0027, B:5:0x001a] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:23:0x0044  */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v0 */
    /* JADX WARN: Type inference failed for: r1v1, types: [android.content.ContentProviderClient] */
    /* JADX WARN: Type inference failed for: r1v2 */
    /* JADX WARN: Type inference failed for: r4v0, types: [android.content.Context] */
    /* JADX WARN: Type inference failed for: r4v12 */
    /* JADX WARN: Type inference failed for: r4v13 */
    /* JADX WARN: Type inference failed for: r4v14 */
    /* JADX WARN: Type inference failed for: r4v2 */
    /* JADX WARN: Type inference failed for: r4v5 */
    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) throws Throwable {
        ContentProviderClient contentProviderClientAcquireUnstableContentProviderClient;
        Bundle bundleCall;
        ContentProviderClient contentProviderClient;
        a aVar = new a();
        ?? r1 = 0;
        try {
            try {
                contentProviderClientAcquireUnstableContentProviderClient = context.getContentResolver().acquireUnstableContentProviderClient(Uri.parse("content://com.pico.idprovider"));
                try {
                    bundleCall = contentProviderClientAcquireUnstableContentProviderClient.call("request_oaid", null, null);
                    context = contentProviderClientAcquireUnstableContentProviderClient;
                    contentProviderClient = contentProviderClientAcquireUnstableContentProviderClient;
                    if (contentProviderClientAcquireUnstableContentProviderClient != null) {
                        contentProviderClient.close();
                        context = contentProviderClient;
                    }
                } catch (RemoteException e) {
                    e = e;
                    e.printStackTrace();
                    bundleCall = null;
                    context = contentProviderClientAcquireUnstableContentProviderClient;
                    contentProviderClient = contentProviderClientAcquireUnstableContentProviderClient;
                    if (contentProviderClientAcquireUnstableContentProviderClient != null) {
                        contentProviderClient.close();
                        context = contentProviderClient;
                    }
                }
            } catch (Throwable th) {
                th = th;
                r1 = context;
                if (r1 != 0) {
                    r1.close();
                }
                throw th;
            }
        } catch (RemoteException e2) {
            e = e2;
            contentProviderClientAcquireUnstableContentProviderClient = null;
        } catch (Throwable th2) {
            th = th2;
            if (r1 != 0) {
                r1.close();
            }
            throw th;
        }
        if (bundleCall != null) {
            aVar.f1727a = bundleCall.getString("oaid", null);
            aVar.b = bundleCall.getBoolean("forbidden", false);
        }
        return aVar;
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        return true;
    }
}
