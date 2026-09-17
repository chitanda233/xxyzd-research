package com.sigmob.sdk.base.common;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLogger;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public abstract class BaseBroadcastReceiver extends BroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3133a = "BaseBroadcastReceiver";
    private final String b;

    public BaseBroadcastReceiver(String broadcastIdentifier) {
        this.b = broadcastIdentifier;
    }

    public static void a(Context context, String broadcastIdentifier, String action) {
        a(context, broadcastIdentifier, null, action, 0);
    }

    public static void a(Context context, String broadcastIdentifier, String action, int delay) {
        a(context, broadcastIdentifier, null, action, delay);
    }

    public static void a(Context context, String broadcastIdentifier, Map<String, Object> extras, String action) {
        a(context, broadcastIdentifier, extras, action, 0);
    }

    public static void a(Context context, String broadcastIdentifier, Map<String, Object> extras, String action, int delay) {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(action);
        Intent intent = new Intent(action);
        intent.putExtra(Constants.BROADCAST_IDENTIFIER_KEY, broadcastIdentifier);
        if (com.sigmob.sdk.base.utils.f.b(extras)) {
            for (String str : extras.keySet()) {
                try {
                    Object obj = extras.get(str);
                    if (obj instanceof Number) {
                        intent.putExtra(str, (Number) obj);
                    } else {
                        intent.putExtra(str, (String) obj);
                    }
                } catch (Throwable th) {
                    SigmobLogger.e(f3133a, "broadcastAction: error = " + th.getMessage(), new Object[0]);
                }
            }
        }
        aj ajVarB = b();
        if (ajVarB == null) {
            return;
        }
        try {
            ajVarB.a(intent, delay);
        } catch (Exception e) {
            SigmobLogger.e(f3133a, "broadcastAction: error = " + e.getMessage(), new Object[0]);
        }
    }

    private static aj b() {
        Context contextE = com.sigmob.sdk.b.e();
        if (contextE == null) {
            return null;
        }
        return aj.a(contextE);
    }

    protected abstract IntentFilter a();

    public void a(BroadcastReceiver broadcastReceiver) {
        aj ajVarB;
        if (broadcastReceiver == null || (ajVarB = b()) == null) {
            return;
        }
        try {
            ajVarB.a(broadcastReceiver, a());
        } catch (Exception e) {
            SigmobLogger.e(f3133a, "register: error = " + e.getMessage(), new Object[0]);
        }
    }

    protected boolean a(Intent intent) {
        Preconditions.NoThrow.checkNotNull(intent);
        String stringExtra = intent.getStringExtra(Constants.BROADCAST_IDENTIFIER_KEY);
        return com.sigmob.sdk.base.utils.s.b(stringExtra) && stringExtra.equalsIgnoreCase(this.b);
    }

    public void b(BroadcastReceiver broadcastReceiver) {
        aj ajVarB;
        if (broadcastReceiver == null || (ajVarB = b()) == null) {
            return;
        }
        try {
            ajVarB.a(broadcastReceiver);
        } catch (Exception e) {
            SigmobLogger.e(f3133a, "unregister: error = " + e.getMessage(), new Object[0]);
        }
    }
}
