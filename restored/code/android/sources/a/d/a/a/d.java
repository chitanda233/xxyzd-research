package a.d.a.a;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.text.TextUtils;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes.dex */
public class d extends BroadcastReceiver {
    /* JADX WARN: Code duplicated, block: B:16:0x0045  */
    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        a aVar;
        if (context == null || intent == null) {
            return;
        }
        boolean zContains = false;
        int intExtra = intent.getIntExtra("openIdNotifyFlag", 0);
        String str = "shouldUpdateId, notifyFlag : " + intExtra;
        if (intExtra == 1) {
            if (TextUtils.equals(intent.getStringExtra("openIdPackage"), context.getPackageName())) {
                zContains = true;
            }
        } else if (intExtra == 2) {
            ArrayList<String> stringArrayListExtra = intent.getStringArrayListExtra("openIdPackageList");
            if (stringArrayListExtra != null) {
                zContains = stringArrayListExtra.contains(context.getPackageName());
            }
        } else if (intExtra == 0) {
            zContains = true;
        }
        if (zContains) {
            String stringExtra = intent.getStringExtra("openIdType");
            e eVarA = e.a();
            eVarA.getClass();
            if ("oaid".equals(stringExtra)) {
                aVar = eVarA.b;
            } else if ("vaid".equals(stringExtra)) {
                aVar = eVarA.d;
            } else if ("aaid".equals(stringExtra)) {
                aVar = eVarA.c;
            } else {
                aVar = "udid".equals(stringExtra) ? eVarA.f26a : null;
            }
            if (aVar == null) {
                return;
            }
            aVar.f23a = 0L;
        }
    }
}
