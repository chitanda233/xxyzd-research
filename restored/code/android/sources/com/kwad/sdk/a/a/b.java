package com.kwad.sdk.a.a;

import android.content.Context;
import com.baidu.mobads.sdk.internal.bn;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bg;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Stack;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    private static volatile b aGZ;
    private Stack<AdTemplate> aGX = new Stack<>();
    private File aGY;
    private boolean mHasInit;

    public interface a {
        void Hw();

        void hI();
    }

    static /* synthetic */ boolean a(b bVar) {
        return Ht();
    }

    private b() {
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized File Hs() {
        File file = this.aGY;
        if (file != null) {
            return file;
        }
        String strEh = bg.eh(ServiceProvider.getContext());
        File file2 = new File(strEh);
        if (!file2.exists()) {
            file2.mkdir();
        }
        File file3 = new File(strEh + File.separator + "uninstall_ad");
        this.aGY = file3;
        if (!file3.exists()) {
            try {
                this.aGY.createNewFile();
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                com.kwad.components.core.d.a.reportSdkCaughtException(e);
            }
        }
        return this.aGY;
    }

    private static boolean Ht() {
        return com.kwad.sdk.core.config.e.JR() == 0;
    }

    public final synchronized void a(final a aVar) {
        if (this.mHasInit) {
            return;
        }
        this.mHasInit = true;
        i.execute(new bi() { // from class: com.kwad.sdk.a.a.b.1
            /* JADX WARN: Not initialized variable reg: 4, insn: 0x0124: MOVE (r3 I:??[OBJECT, ARRAY]) = (r4 I:??[OBJECT, ARRAY]), block:B:71:0x0124 */
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ObjectInputStream objectInputStream;
                ObjectOutputStream objectOutputStream;
                try {
                    if (b.a(b.this) || com.kwad.sdk.a.a.a.b.dT() > 0) {
                        return;
                    }
                    HashMap map = new HashMap();
                    File fileHs = b.this.Hs();
                    ObjectOutputStream objectOutputStream2 = null;
                    try {
                        try {
                            if (!fileHs.exists()) {
                                com.kwad.sdk.core.d.c.d("InstallTipsDataManager", "getCanShowDownloadData mDownloadFile is not exists");
                            }
                            b.this.aGX.clear();
                            objectInputStream = new ObjectInputStream(new FileInputStream(fileHs));
                            try {
                                b.this.aGX = (Stack) objectInputStream.readObject();
                                if (!b.this.aGX.isEmpty()) {
                                    Stack stack = new Stack();
                                    while (!b.this.aGX.isEmpty()) {
                                        AdTemplate adTemplate = (AdTemplate) b.this.aGX.pop();
                                        if (adTemplate != null) {
                                            String strValueOf = String.valueOf(com.kwad.sdk.core.response.helper.e.eW(adTemplate));
                                            File fileBo = b.bo(adTemplate);
                                            if (fileBo != null && fileBo.exists() && fileBo.lastModified() + bn.d > System.currentTimeMillis()) {
                                                stack.push(adTemplate);
                                            } else {
                                                map.put(strValueOf, Boolean.TRUE);
                                            }
                                        }
                                    }
                                    while (!stack.isEmpty()) {
                                        b.this.aGX.push((AdTemplate) stack.pop());
                                    }
                                }
                            } catch (Exception e) {
                                e = e;
                                com.kwad.sdk.core.d.c.d("InstallTipsDataManager", " getCanShowDownloadBannerData e" + e);
                                a aVar2 = aVar;
                                if (aVar2 != null) {
                                    aVar2.Hw();
                                    com.kwad.sdk.crash.utils.b.closeQuietly(objectInputStream);
                                    com.kwad.sdk.crash.utils.b.closeQuietly(objectInputStream);
                                    return;
                                }
                            }
                        } catch (Throwable th) {
                            th = th;
                            objectOutputStream2 = objectOutputStream;
                            com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                            throw th;
                        }
                    } catch (Exception e2) {
                        e = e2;
                        objectInputStream = null;
                    } catch (Throwable th2) {
                        th = th2;
                        com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                        throw th;
                    }
                    com.kwad.sdk.crash.utils.b.closeQuietly(objectInputStream);
                    try {
                        try {
                            ObjectOutputStream objectOutputStream3 = new ObjectOutputStream(new FileOutputStream(fileHs));
                            try {
                                objectOutputStream3.writeObject(b.this.aGX);
                                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream3);
                            } catch (Exception e3) {
                                e = e3;
                                objectOutputStream2 = objectOutputStream3;
                                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                                com.kwad.components.core.d.a.reportSdkCaughtException(e);
                                a aVar3 = aVar;
                                if (aVar3 != null) {
                                    aVar3.Hw();
                                    com.kwad.sdk.crash.utils.b.closeQuietly(objectInputStream);
                                    com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                                    return;
                                }
                                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                                throw th;
                            } catch (Throwable th3) {
                                th = th3;
                                objectOutputStream2 = objectOutputStream3;
                                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream2);
                                throw th;
                            }
                        } catch (Exception e4) {
                            e = e4;
                        }
                        a aVar4 = aVar;
                        if (aVar4 != null) {
                            aVar4.hI();
                        }
                    } catch (Throwable th4) {
                        th = th4;
                    }
                } catch (Throwable th5) {
                    com.kwad.components.core.d.a.reportSdkCaughtException(th5);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void bk(AdTemplate adTemplate) {
        ObjectOutputStream objectOutputStream;
        Throwable th;
        Exception e;
        Iterator<AdTemplate> it = this.aGX.iterator();
        boolean z = false;
        while (it.hasNext()) {
            if (com.kwad.sdk.core.response.helper.e.eW(it.next()) == com.kwad.sdk.core.response.helper.e.eW(adTemplate)) {
                it.remove();
                z = true;
            }
        }
        if (!z) {
            return;
        }
        try {
            objectOutputStream = new ObjectOutputStream(new FileOutputStream(this.aGY));
            try {
                try {
                    objectOutputStream.writeObject(this.aGX);
                    com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                } catch (Exception e2) {
                    e = e2;
                    com.kwad.sdk.core.d.c.d("InstallTipsDataManager", " removeApkDownloadedData e" + e);
                    com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                }
            } catch (Throwable th2) {
                th = th2;
                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                throw th;
            }
        } catch (Exception e3) {
            objectOutputStream = null;
            e = e3;
        } catch (Throwable th3) {
            objectOutputStream = null;
            th = th3;
            com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
            throw th;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized void bl(AdTemplate adTemplate) {
        ObjectOutputStream objectOutputStream;
        Throwable th;
        Exception e;
        this.aGX.add(adTemplate);
        try {
            objectOutputStream = new ObjectOutputStream(new FileOutputStream(Hs()));
            try {
                try {
                    objectOutputStream.writeObject(this.aGX);
                    com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                } catch (Exception e2) {
                    e = e2;
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                    com.kwad.components.core.d.a.reportSdkCaughtException(e);
                    com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                }
            } catch (Throwable th2) {
                th = th2;
                com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
                throw th;
            }
        } catch (Exception e3) {
            objectOutputStream = null;
            e = e3;
        } catch (Throwable th3) {
            objectOutputStream = null;
            th = th3;
            com.kwad.sdk.crash.utils.b.closeQuietly(objectOutputStream);
            throw th;
        }
    }

    public static b Hu() {
        if (aGZ == null) {
            synchronized (b.class) {
                if (aGZ == null) {
                    aGZ = new b();
                }
            }
        }
        return aGZ;
    }

    public final void bm(final AdTemplate adTemplate) {
        if (Ht() || adTemplate == null) {
            return;
        }
        i.execute(new bi() { // from class: com.kwad.sdk.a.a.b.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                b.this.bl(adTemplate);
            }
        });
    }

    public final void bn(final AdTemplate adTemplate) {
        if (Ht() || adTemplate == null) {
            return;
        }
        i.execute(new bi() { // from class: com.kwad.sdk.a.a.b.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                b.this.bk(adTemplate);
            }
        });
    }

    public final synchronized AdTemplate Hv() {
        AdTemplate adTemplate;
        Stack stack = (Stack) this.aGX.clone();
        while (!stack.isEmpty()) {
            adTemplate = (AdTemplate) stack.pop();
            if (adTemplate != null) {
                String str = com.kwad.sdk.core.response.helper.e.eM(adTemplate).adBaseInfo.appPackageName;
                Context context = ServiceProvider.getContext();
                File fileBo = bo(adTemplate);
                if (fileBo == null || !fileBo.exists() || fileBo.lastModified() + bn.d <= System.currentTimeMillis() || au.aw(context, str)) {
                }
            }
        }
        adTemplate = null;
        return adTemplate;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static File bo(AdTemplate adTemplate) {
        File file = new File(com.kwad.sdk.core.download.a.J(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
        if (y.Q(file)) {
            return file;
        }
        return null;
    }
}
