package com.kwad.sdk.utils;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.net.Uri;
import android.os.Handler;
import android.os.Message;
import android.util.Log;
import com.bytedance.pangle.LocalBroadcastManager;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class af {
    private static af bpj;
    private static final Object mLock = new Object();
    private final Context bpf;
    private final HashMap<BroadcastReceiver, ArrayList<b>> bpg = new HashMap<>();
    private final HashMap<String, ArrayList<b>> bph = new HashMap<>();
    private final ArrayList<a> bpi = new ArrayList<>();
    private final Handler jc;

    static final class b {
        final BroadcastReceiver bpm;
        boolean bpn;
        boolean bpo;
        final IntentFilter filter;

        b(IntentFilter intentFilter, BroadcastReceiver broadcastReceiver) {
            this.filter = intentFilter;
            this.bpm = broadcastReceiver;
        }

        public final String toString() {
            StringBuilder sb = new StringBuilder(128);
            sb.append("Receiver{");
            sb.append(this.bpm);
            sb.append(" filter=");
            sb.append(this.filter);
            if (this.bpo) {
                sb.append(" DEAD");
            }
            sb.append(com.alipay.sdk.m.y.l.d);
            return sb.toString();
        }
    }

    static final class a {
        final ArrayList<b> bpl;
        final Intent intent;

        a(Intent intent, ArrayList<b> arrayList) {
            this.intent = intent;
            this.bpl = arrayList;
        }
    }

    public static af di(Context context) {
        af afVar;
        synchronized (mLock) {
            if (bpj == null) {
                bpj = new af(context.getApplicationContext());
            }
            afVar = bpj;
        }
        return afVar;
    }

    private af(Context context) {
        this.bpf = context;
        this.jc = new Handler(context.getMainLooper()) { // from class: com.kwad.sdk.utils.af.1
            @Override // android.os.Handler
            public final void handleMessage(Message message) {
                if (message.what == 1) {
                    af.this.Va();
                } else {
                    super.handleMessage(message);
                }
            }
        };
    }

    public final void a(BroadcastReceiver broadcastReceiver, IntentFilter intentFilter) {
        synchronized (this.bpg) {
            b bVar = new b(intentFilter, broadcastReceiver);
            ArrayList<b> arrayList = this.bpg.get(broadcastReceiver);
            if (arrayList == null) {
                arrayList = new ArrayList<>(1);
                this.bpg.put(broadcastReceiver, arrayList);
            }
            arrayList.add(bVar);
            for (int i = 0; i < intentFilter.countActions(); i++) {
                String action = intentFilter.getAction(i);
                ArrayList<b> arrayList2 = this.bph.get(action);
                if (arrayList2 == null) {
                    arrayList2 = new ArrayList<>(1);
                    this.bph.put(action, arrayList2);
                }
                arrayList2.add(bVar);
            }
        }
    }

    public final void unregisterReceiver(BroadcastReceiver broadcastReceiver) {
        synchronized (this.bpg) {
            ArrayList<b> arrayListRemove = this.bpg.remove(broadcastReceiver);
            if (arrayListRemove == null) {
                return;
            }
            for (int size = arrayListRemove.size() - 1; size >= 0; size--) {
                b bVar = arrayListRemove.get(size);
                bVar.bpo = true;
                for (int i = 0; i < bVar.filter.countActions(); i++) {
                    String action = bVar.filter.getAction(i);
                    ArrayList<b> arrayList = this.bph.get(action);
                    if (arrayList != null) {
                        for (int size2 = arrayList.size() - 1; size2 >= 0; size2--) {
                            b bVar2 = arrayList.get(size2);
                            if (bVar2.bpm == broadcastReceiver) {
                                bVar2.bpo = true;
                                arrayList.remove(size2);
                            }
                        }
                        if (arrayList.size() <= 0) {
                            this.bph.remove(action);
                        }
                    }
                }
            }
        }
    }

    public final boolean i(Intent intent) {
        int i;
        String str;
        ArrayList arrayList;
        ArrayList<b> arrayList2;
        String str2;
        String str3;
        synchronized (this.bpg) {
            String action = intent.getAction();
            String strResolveTypeIfNeeded = intent.resolveTypeIfNeeded(this.bpf.getContentResolver());
            Uri data = intent.getData();
            String scheme = intent.getScheme();
            Set<String> categories = intent.getCategories();
            boolean z = (intent.getFlags() & 8) != 0;
            if (z) {
                Log.v("KsLocalBroadcastManager", "Resolving type " + strResolveTypeIfNeeded + " scheme " + scheme + " of intent " + intent);
            }
            ArrayList<b> arrayList3 = this.bph.get(intent.getAction());
            if (arrayList3 != null) {
                if (z) {
                    Log.v("KsLocalBroadcastManager", "Action list: " + arrayList3);
                }
                ArrayList arrayList4 = null;
                int i2 = 0;
                while (i2 < arrayList3.size()) {
                    b bVar = arrayList3.get(i2);
                    if (z) {
                        Log.v("KsLocalBroadcastManager", "Matching against filter " + bVar.filter);
                    }
                    if (bVar.bpn) {
                        if (z) {
                            Log.v("KsLocalBroadcastManager", "  Filter's target already added");
                        }
                        i = i2;
                        arrayList2 = arrayList3;
                        str = action;
                        str2 = strResolveTypeIfNeeded;
                        arrayList = arrayList4;
                    } else {
                        i = i2;
                        str = action;
                        arrayList = arrayList4;
                        arrayList2 = arrayList3;
                        str2 = strResolveTypeIfNeeded;
                        int iMatch = bVar.filter.match(action, strResolveTypeIfNeeded, scheme, data, categories, LocalBroadcastManager.TAG);
                        if (iMatch >= 0) {
                            if (z) {
                                Log.v("KsLocalBroadcastManager", "  Filter matched!  match=0x" + Integer.toHexString(iMatch));
                            }
                            arrayList4 = arrayList == null ? new ArrayList() : arrayList;
                            arrayList4.add(bVar);
                            bVar.bpn = true;
                        } else if (z) {
                            if (iMatch == -4) {
                                str3 = PointParamKey.CATEGORY;
                            } else if (iMatch == -3) {
                                str3 = "action";
                            } else if (iMatch != -2) {
                                str3 = iMatch != -1 ? "unknown reason" : "type";
                            } else {
                                str3 = "data";
                            }
                            Log.v("KsLocalBroadcastManager", "  Filter did not match: " + str3);
                        }
                        i2 = i + 1;
                        action = str;
                        arrayList3 = arrayList2;
                        strResolveTypeIfNeeded = str2;
                    }
                    arrayList4 = arrayList;
                    i2 = i + 1;
                    action = str;
                    arrayList3 = arrayList2;
                    strResolveTypeIfNeeded = str2;
                }
                ArrayList arrayList5 = arrayList4;
                if (arrayList5 != null) {
                    for (int i3 = 0; i3 < arrayList5.size(); i3++) {
                        ((b) arrayList5.get(i3)).bpn = false;
                    }
                    this.bpi.add(new a(intent, arrayList5));
                    if (!this.jc.hasMessages(1)) {
                        this.jc.sendEmptyMessage(1);
                    }
                    return true;
                }
            }
            return false;
        }
    }

    final void Va() {
        int size;
        a[] aVarArr;
        while (true) {
            synchronized (this.bpg) {
                size = this.bpi.size();
                if (size <= 0) {
                    return;
                }
                aVarArr = new a[size];
                this.bpi.toArray(aVarArr);
                this.bpi.clear();
            }
            for (int i = 0; i < size; i++) {
                a aVar = aVarArr[i];
                int size2 = aVar.bpl.size();
                for (int i2 = 0; i2 < size2; i2++) {
                    b bVar = aVar.bpl.get(i2);
                    if (!bVar.bpo) {
                        bVar.bpm.onReceive(this.bpf, aVar.intent);
                    }
                }
            }
        }
    }
}
