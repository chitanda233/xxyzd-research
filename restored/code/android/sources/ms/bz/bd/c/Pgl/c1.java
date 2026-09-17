package ms.bz.bd.c.Pgl;

import android.content.ContentProviderClient;
import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes4.dex */
public final class c1 {
    private final Context c;

    public c1(Context context) {
        this.c = context;
    }

    public final String c() {
        try {
            ContentProviderClient contentProviderClientAcquireContentProviderClient = this.c.getContentResolver().acquireContentProviderClient(Uri.parse((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "9e76b8", new byte[]{43, 104, 74, 86, com.sigmob.sdk.archives.tar.e.S, 33, 46, 30, 41, 41, 43, 105, 10, com.sigmob.sdk.archives.tar.e.P, 72, 45, com.sigmob.sdk.archives.tar.e.K, 69, 40, 111, 44, 98, 74, 86, 84, 59, 35, 11, 111, 98, 45, 105, 80, 75, 73, com.sigmob.sdk.archives.tar.e.N})));
            Bundle bundleCall = contentProviderClientAcquireContentProviderClient.call((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "868c98", new byte[]{46, com.sigmob.sdk.archives.tar.e.I, 95, 56, 39, 6, 31}), null, null);
            contentProviderClientAcquireContentProviderClient.close();
            if (bundleCall.getInt((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "77257d", new byte[]{37, 58, 69, 68}), -1) == 0) {
                return bundleCall.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "aca116", new byte[]{121, 101}));
            }
            bundleCall.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "c5ec86", new byte[]{ByteCompanionObject.MAX_VALUE, com.sigmob.sdk.archives.tar.e.J, 5, 4, 6, 38, 101}));
            return null;
        } catch (Exception unused) {
        }
    }
}
