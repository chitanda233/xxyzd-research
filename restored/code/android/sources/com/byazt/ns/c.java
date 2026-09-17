package com.byazt.ns;

import android.text.TextUtils;
import com.byazt.byh.ve;
import com.byazt.jzl.a;
import com.byazt.nr.m;
import com.byazt.nr.sp;
import com.byazt.utw.uj;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Queue;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, 20})
public final class c {
    public static final boolean c = com.byazt.lt.tt.tt();
    public HashMap<String, Boolean> tt;
    public C0199c ve;

    private c() {
        this.tt = new HashMap<>();
        tt();
    }

    public static c c() {
        return tt.c;
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, MediaPlayer.MEDIA_PLAYER_OPTION_ABR_AVERAGE_PLAY_SPEED})
    private static class tt {
        public static final c c = new c();
    }

    public boolean tt() {
        if (this.ve != null) {
            return true;
        }
        ve veVarVe = ve();
        if (veVarVe == null) {
            return false;
        }
        uj.c(true);
        uj.c(1);
        try {
            C0199c c0199c = new C0199c();
            this.ve = c0199c;
            c0199c.setName("csj_v_c_preloader");
            this.ve.start();
            uj.c(veVarVe, com.byazt.oy.tt.getContext());
            com.byazt.utw.ve.c();
            com.byazt.utw.ve.c().c(10485759);
            return true;
        } catch (Exception unused) {
            return false;
        }
    }

    public boolean c(a aVar) {
        if (!tt()) {
            return false;
        }
        this.ve.c(aVar);
        return true;
    }

    private static ve ve() {
        ve veVar = null;
        File file = new File(sp.tt(com.byazt.oy.tt.getContext(), false, null), "proxy_cache");
        if (!file.exists()) {
            file.mkdirs();
        }
        try {
            ve veVar2 = new ve(file);
            try {
                veVar2.c(104857600L);
                return veVar2;
            } catch (IOException e) {
                e = e;
                veVar = veVar2;
                m.c(e);
                return veVar;
            }
        } catch (IOException e2) {
            e = e2;
        }
    }

    /* JADX INFO: renamed from: com.byazt.ns.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, 44})
    class C0199c extends com.byazt.jtc.ve {
        public Queue<C0200c> n;
        public Queue<C0200c> tt;
        public final Queue<C0200c> uj;
        public boolean ve;

        public C0199c() {
            super("VideoCachePreloader$PreLoadThread");
            this.uj = new ArrayBlockingQueue(10);
            this.tt = new LinkedBlockingQueue();
            this.ve = true;
            this.n = new LinkedBlockingQueue();
        }

        private C0200c c(int i, a aVar) {
            this.uj.size();
            C0200c c0200cPoll = this.uj.poll();
            if (c0200cPoll == null) {
                c0200cPoll = new C0200c();
            }
            c0200cPoll.c = i;
            c0200cPoll.f1229a = aVar;
            return c0200cPoll;
        }

        private void c(C0200c c0200c) {
            c0200c.ve = null;
            c0200c.tt = null;
            c0200c.c = -1;
            c0200c.f1229a = null;
            this.uj.offer(c0200c);
        }

        private synchronized void tt(C0200c c0200c) {
            this.n.add(c0200c);
            notify();
        }

        private void ve(C0200c c0200c) {
            if (c0200c == null) {
                return;
            }
            this.tt.offer(c0200c);
            notify();
        }

        @Override // java.lang.Thread, java.lang.Runnable
        public void run() {
            while (this.ve) {
                synchronized (this) {
                    if (!this.n.isEmpty()) {
                        c();
                    }
                    while (!this.tt.isEmpty()) {
                        C0200c c0200cPoll = this.tt.poll();
                        if (c0200cPoll != null) {
                            int i = c0200cPoll.c;
                            if (i != 0) {
                                if (i == 1) {
                                    com.byazt.utw.ve.c().c(c0200cPoll.tt);
                                } else if (i == 2) {
                                    com.byazt.utw.ve.c().tt();
                                } else if (i == 3) {
                                    com.byazt.utw.ve.c().tt();
                                    if (uj.tt() != null) {
                                        uj.tt().c();
                                    }
                                    if (uj.c() != null) {
                                        uj.c().c();
                                    }
                                } else if (i == 4) {
                                    com.byazt.utw.ve.c().tt();
                                    this.ve = false;
                                }
                            } else if (c0200cPoll.ve != null && c0200cPoll.ve.length > 0) {
                                ArrayList arrayList = new ArrayList();
                                for (String str : c0200cPoll.ve) {
                                    if (com.byazt.nxx.c.c(str)) {
                                        arrayList.add(str);
                                    }
                                }
                                com.byazt.utw.ve.c().c(false, !TextUtils.isEmpty(c0200cPoll.n), c0200cPoll.uj, c0200cPoll.tt, (String[]) arrayList.toArray(new String[arrayList.size()]));
                            }
                            c(c0200cPoll);
                        }
                    }
                    try {
                        wait();
                    } catch (InterruptedException e) {
                        m.c(e);
                    }
                }
            }
        }

        private void c() {
            while (true) {
                C0200c c0200cPoll = this.n.poll();
                if (c0200cPoll == null) {
                    return;
                }
                c0200cPoll.tt = c0200cPoll.f1229a.getUrl();
                c0200cPoll.ve = new String[]{c0200cPoll.f1229a.getUrl()};
                int pitayaCacheSize = c0200cPoll.f1229a.getPitayaCacheSize();
                if (pitayaCacheSize <= 0) {
                    pitayaCacheSize = c0200cPoll.f1229a.getPreloadSize();
                }
                c0200cPoll.uj = pitayaCacheSize;
                c0200cPoll.n = c0200cPoll.f1229a.getFileNameKey();
                if (!TextUtils.isEmpty(c0200cPoll.f1229a.getFileNameKey())) {
                    c0200cPoll.tt = c0200cPoll.f1229a.getFileNameKey();
                }
                c0200cPoll.f1229a = null;
                ve(c0200cPoll);
            }
        }

        public void c(a aVar) {
            tt(c(0, aVar));
        }

        /* JADX INFO: renamed from: com.byazt.ns.c$c$c, reason: collision with other inner class name */
        @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_RANGE_SIZE, 810})
        private class C0200c {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public a f1229a;
            public int c;
            public String n;
            public String tt;
            public int uj;
            public String[] ve;

            public C0200c() {
            }
        }
    }
}
