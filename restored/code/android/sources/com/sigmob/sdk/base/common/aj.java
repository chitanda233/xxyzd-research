package com.sigmob.sdk.base.common;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.net.Uri;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.util.Log;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public class aj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static final int f3146a = 1;
    private static final String b = "LocalBroadcastManager";
    private static final boolean c = false;
    private static final Object d = new Object();
    private static aj e;
    private final Context f;
    private final HashMap<BroadcastReceiver, ArrayList<b>> g = new HashMap<>();
    private final HashMap<String, ArrayList<b>> h = new HashMap<>();
    private final ArrayList<a> i = new ArrayList<>();
    private final Handler j = new Handler(Looper.getMainLooper()) { // from class: com.sigmob.sdk.base.common.aj.1
        @Override // android.os.Handler
        public void handleMessage(Message msg) {
            if (msg.what == 1) {
                aj.this.a();
            } else {
                super.handleMessage(msg);
            }
        }
    };

    private static final class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final Intent f3148a;
        final ArrayList<b> b;

        a(Intent _intent, ArrayList<b> _receivers) {
            this.f3148a = _intent;
            this.b = _receivers;
        }
    }

    private static final class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final IntentFilter f3149a;
        final BroadcastReceiver b;
        boolean c;
        boolean d;

        b(IntentFilter _filter, BroadcastReceiver _receiver) {
            this.f3149a = _filter;
            this.b = _receiver;
        }

        public String toString() {
            StringBuilder sb = new StringBuilder(128);
            sb.append("Receiver{");
            sb.append(this.b);
            sb.append(" filter=");
            sb.append(this.f3149a);
            if (this.d) {
                sb.append(" DEAD");
            }
            sb.append(com.alipay.sdk.m.y.l.d);
            return sb.toString();
        }
    }

    private aj(Context context) {
        this.f = context;
    }

    public static aj a(Context context) {
        aj ajVar;
        synchronized (d) {
            if (e == null) {
                e = new aj(context.getApplicationContext());
            }
            ajVar = e;
        }
        return ajVar;
    }

    void a() {
        int size;
        a[] aVarArr;
        while (true) {
            synchronized (this.g) {
                size = this.i.size();
                if (size <= 0) {
                    return;
                }
                aVarArr = new a[size];
                this.i.toArray(aVarArr);
                this.i.clear();
            }
            for (int i = 0; i < size; i++) {
                a aVar = aVarArr[i];
                int size2 = aVar.b.size();
                for (int i2 = 0; i2 < size2; i2++) {
                    b bVar = aVar.b.get(i2);
                    if (!bVar.d) {
                        bVar.b.onReceive(this.f, aVar.f3148a);
                    }
                }
            }
        }
    }

    public void a(BroadcastReceiver receiver) {
        synchronized (this.g) {
            ArrayList<b> arrayListRemove = this.g.remove(receiver);
            if (arrayListRemove == null) {
                return;
            }
            for (int size = arrayListRemove.size() - 1; size >= 0; size--) {
                b bVar = arrayListRemove.get(size);
                bVar.d = true;
                for (int i = 0; i < bVar.f3149a.countActions(); i++) {
                    String action = bVar.f3149a.getAction(i);
                    ArrayList<b> arrayList = this.h.get(action);
                    if (arrayList != null) {
                        for (int size2 = arrayList.size() - 1; size2 >= 0; size2--) {
                            b bVar2 = arrayList.get(size2);
                            if (bVar2.b == receiver) {
                                bVar2.d = true;
                                arrayList.remove(size2);
                            }
                        }
                        if (arrayList.size() <= 0) {
                            this.h.remove(action);
                        }
                    }
                }
            }
        }
    }

    public void a(BroadcastReceiver receiver, IntentFilter filter) {
        synchronized (this.g) {
            b bVar = new b(filter, receiver);
            ArrayList<b> arrayList = this.g.get(receiver);
            if (arrayList == null) {
                arrayList = new ArrayList<>(1);
                this.g.put(receiver, arrayList);
            }
            arrayList.add(bVar);
            for (int i = 0; i < filter.countActions(); i++) {
                String action = filter.getAction(i);
                ArrayList<b> arrayList2 = this.h.get(action);
                if (arrayList2 == null) {
                    arrayList2 = new ArrayList<>(1);
                    this.h.put(action, arrayList2);
                }
                arrayList2.add(bVar);
            }
        }
    }

    public boolean a(Intent intent) {
        return a(intent, 0);
    }

    public boolean a(Intent intent, int delay) {
        int i;
        ArrayList<b> arrayList;
        String str;
        String str2;
        String str3;
        synchronized (this.g) {
            String action = intent.getAction();
            String strResolveTypeIfNeeded = intent.resolveTypeIfNeeded(this.f.getContentResolver());
            Uri data = intent.getData();
            String scheme = intent.getScheme();
            Set<String> categories = intent.getCategories();
            boolean z = (intent.getFlags() & 8) != 0;
            if (z) {
                Log.v("LocalBroadcastManager", "Resolving type " + strResolveTypeIfNeeded + " scheme " + scheme + " of intent " + intent);
            }
            ArrayList<b> arrayList2 = this.h.get(intent.getAction());
            if (arrayList2 == null) {
                return false;
            }
            if (z) {
                Log.v("LocalBroadcastManager", "Action list: " + arrayList2);
            }
            ArrayList arrayList3 = null;
            int i2 = 0;
            while (i2 < arrayList2.size()) {
                b bVar = arrayList2.get(i2);
                if (z) {
                    Log.v("LocalBroadcastManager", "Matching against filter " + bVar.f3149a);
                }
                if (bVar.c) {
                    if (z) {
                        Log.v("LocalBroadcastManager", "  Filter's target already added");
                    }
                    arrayList = arrayList2;
                    i = i2;
                    str2 = scheme;
                    str = action;
                } else {
                    i = i2;
                    arrayList = arrayList2;
                    str = action;
                    str2 = scheme;
                    int iMatch = bVar.f3149a.match(action, strResolveTypeIfNeeded, scheme, data, categories, "LocalBroadcastManager");
                    if (iMatch >= 0) {
                        if (z) {
                            Log.v("LocalBroadcastManager", "  Filter matched! match=0x" + Integer.toHexString(iMatch));
                        }
                        if (arrayList3 == null) {
                            arrayList3 = new ArrayList();
                        }
                        arrayList3.add(bVar);
                        bVar.c = true;
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
                        Log.v("LocalBroadcastManager", "  Filter did not match: " + str3);
                    }
                }
                i2 = i + 1;
                action = str;
                arrayList2 = arrayList;
                scheme = str2;
            }
            if (arrayList3 == null) {
                return false;
            }
            for (int i3 = 0; i3 < arrayList3.size(); i3++) {
                ((b) arrayList3.get(i3)).c = false;
            }
            this.i.add(new a(intent, arrayList3));
            if (!this.j.hasMessages(1)) {
                if (delay > 0) {
                    this.j.sendEmptyMessageDelayed(1, delay);
                } else {
                    this.j.sendEmptyMessage(1);
                }
            }
            return true;
        }
    }

    public void b(Intent intent) {
        if (a(intent)) {
            a();
        }
    }
}
