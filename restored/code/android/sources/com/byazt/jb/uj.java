package com.byazt.jb;

import com.alipay.sdk.m.c0.d;
import com.alipay.sdk.m.t.e;
import com.baidu.mobads.sdk.internal.cm;
import com.byazt.mk.my;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.sigmob.sdk.downloader.core.breakpoint.f;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import kotlin.UByte;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 63, 15})
public final class uj {
    public static final ve[] c = {new ve(ve.f1074a, ""), new ve(ve.ve, "GET"), new ve(ve.ve, "POST"), new ve(ve.uj, "/"), new ve(ve.uj, "/index.html"), new ve(ve.n, "http"), new ve(ve.n, "https"), new ve(ve.tt, "200"), new ve(ve.tt, "204"), new ve(ve.tt, "206"), new ve(ve.tt, "304"), new ve(ve.tt, "400"), new ve(ve.tt, cm.b), new ve(ve.tt, "500"), new ve("accept-charset", ""), new ve("accept-encoding", "gzip, deflate"), new ve("accept-language", ""), new ve("accept-ranges", ""), new ve("accept", ""), new ve("access-control-allow-origin", ""), new ve("age", ""), new ve("allow", ""), new ve("authorization", ""), new ve("cache-control", ""), new ve("content-disposition", ""), new ve("content-encoding", ""), new ve("content-language", ""), new ve("content-length", ""), new ve("content-location", ""), new ve("content-range", ""), new ve(e.f, ""), new ve("cookie", ""), new ve("date", ""), new ve(f.c, ""), new ve("expect", ""), new ve("expires", ""), new ve("from", ""), new ve(com.alipay.sdk.m.n.c.f, ""), new ve("if-match", ""), new ve("if-modified-since", ""), new ve("if-none-match", ""), new ve("if-range", ""), new ve("if-unmodified-since", ""), new ve("last-modified", ""), new ve("link", ""), new ve("location", ""), new ve("max-forwards", ""), new ve("proxy-authenticate", ""), new ve("proxy-authorization", ""), new ve("range", ""), new ve("referer", ""), new ve(d.x, ""), new ve("retry-after", ""), new ve("server", ""), new ve("set-cookie", ""), new ve("strict-transport-security", ""), new ve("transfer-encoding", ""), new ve("user-agent", ""), new ve("vary", ""), new ve("via", ""), new ve("www-authenticate", "")};
    public static final Map<com.byazt.mk.a, Integer> tt = c();

    @com.byazt.zqa.c(c = {0, 1, 63, 123})
    static final class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final com.byazt.mk.n f1072a;
        public ve[] c;
        public final List<ve> n;
        public final int sp;
        public int tt;
        public int uj;
        public int ve;
        public int x;

        public c(int i, my myVar) {
            this(i, i, myVar);
        }

        public c(int i, int i2, my myVar) {
            this.n = new ArrayList();
            ve[] veVarArr = new ve[8];
            this.c = veVarArr;
            this.tt = veVarArr.length - 1;
            this.ve = 0;
            this.uj = 0;
            this.sp = i;
            this.x = i2;
            this.f1072a = com.byazt.mk.t.c(myVar);
        }

        private void uj() {
            int i = this.x;
            int i2 = this.uj;
            if (i < i2) {
                if (i == 0) {
                    n();
                } else {
                    c(i2 - i);
                }
            }
        }

        private void n() {
            Arrays.fill(this.c, (Object) null);
            this.tt = this.c.length - 1;
            this.ve = 0;
            this.uj = 0;
        }

        private int c(int i) {
            int i2;
            int i3 = 0;
            if (i > 0) {
                int length = this.c.length;
                while (true) {
                    length--;
                    i2 = this.tt;
                    if (length < i2 || i <= 0) {
                        break;
                    }
                    i -= this.c[length].i;
                    this.uj -= this.c[length].i;
                    this.ve--;
                    i3++;
                }
                ve[] veVarArr = this.c;
                System.arraycopy(veVarArr, i2 + 1, veVarArr, i2 + 1 + i3, this.ve);
                this.tt += i3;
            }
            return i3;
        }

        public void c() throws IOException {
            while (!this.f1072a.n()) {
                int iX = this.f1072a.x() & UByte.MAX_VALUE;
                if (iX == 128) {
                    throw new IOException("index == 0");
                }
                if ((iX & 128) == 128) {
                    tt(c(iX, WorkQueueKt.MASK) - 1);
                } else if (iX == 64) {
                    sp();
                } else if ((iX & 64) == 64) {
                    n(c(iX, 63) - 1);
                } else if ((iX & 32) == 32) {
                    int iC = c(iX, 31);
                    this.x = iC;
                    if (iC < 0 || iC > this.sp) {
                        throw new IOException("Invalid dynamic table size update " + this.x);
                    }
                    uj();
                } else if (iX == 16 || iX == 0) {
                    a();
                } else {
                    uj(c(iX, 15) - 1);
                }
            }
        }

        public List<ve> tt() {
            ArrayList arrayList = new ArrayList(this.n);
            this.n.clear();
            return arrayList;
        }

        private void tt(int i) throws IOException {
            if (sp(i)) {
                this.n.add(uj.c[i]);
                return;
            }
            int iVe = ve(i - uj.c.length);
            if (iVe >= 0) {
                ve[] veVarArr = this.c;
                if (iVe <= veVarArr.length - 1) {
                    this.n.add(veVarArr[iVe]);
                    return;
                }
            }
            throw new IOException("Header index too large " + (i + 1));
        }

        private int ve(int i) {
            return this.tt + 1 + i;
        }

        private void uj(int i) throws IOException {
            this.n.add(new ve(a(i), ve()));
        }

        private void a() throws IOException {
            this.n.add(new ve(uj.c(ve()), ve()));
        }

        private void n(int i) throws IOException {
            c(-1, new ve(a(i), ve()));
        }

        private void sp() throws IOException {
            c(-1, new ve(uj.c(ve()), ve()));
        }

        private com.byazt.mk.a a(int i) {
            if (sp(i)) {
                return uj.c[i].sp;
            }
            return this.c[ve(i - uj.c.length)].sp;
        }

        private boolean sp(int i) {
            return i >= 0 && i <= uj.c.length - 1;
        }

        private void c(int i, ve veVar) {
            this.n.add(veVar);
            int i2 = veVar.i;
            if (i != -1) {
                i2 -= this.c[ve(i)].i;
            }
            int i3 = this.x;
            if (i2 > i3) {
                n();
                return;
            }
            int iC = c((this.uj + i2) - i3);
            if (i == -1) {
                int i4 = this.ve + 1;
                ve[] veVarArr = this.c;
                if (i4 > veVarArr.length) {
                    ve[] veVarArr2 = new ve[veVarArr.length * 2];
                    System.arraycopy(veVarArr, 0, veVarArr2, veVarArr.length, veVarArr.length);
                    this.tt = this.c.length - 1;
                    this.c = veVarArr2;
                }
                int i5 = this.tt;
                this.tt = i5 - 1;
                this.c[i5] = veVar;
                this.ve++;
            } else {
                this.c[i + ve(i) + iC] = veVar;
            }
            this.uj += i2;
        }

        private int x() throws IOException {
            return this.f1072a.x() & UByte.MAX_VALUE;
        }

        public int c(int i, int i2) throws IOException {
            int i3 = i & i2;
            if (i3 < i2) {
                return i3;
            }
            int i4 = 0;
            while (true) {
                int iX = x();
                if ((iX & 128) == 0) {
                    return i2 + (iX << i4);
                }
                i2 += (iX & WorkQueueKt.MASK) << i4;
                i4 += 7;
            }
        }

        public com.byazt.mk.a ve() throws IOException {
            int iX = x();
            boolean z = (iX & 128) == 128;
            int iC = c(iX, WorkQueueKt.MASK);
            if (z) {
                return com.byazt.mk.a.c(sl.c().c(this.f1072a.sp(iC)));
            }
            return this.f1072a.ve(iC);
        }
    }

    private static Map<com.byazt.mk.a, Integer> c() {
        LinkedHashMap linkedHashMap = new LinkedHashMap(c.length);
        int i = 0;
        while (true) {
            ve[] veVarArr = c;
            if (i < veVarArr.length) {
                if (!linkedHashMap.containsKey(veVarArr[i].sp)) {
                    linkedHashMap.put(veVarArr[i].sp, Integer.valueOf(i));
                }
                i++;
            } else {
                return Collections.unmodifiableMap(linkedHashMap);
            }
        }
    }

    @com.byazt.zqa.c(c = {0, 1, 63, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT})
    static final class tt {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public int f1073a;
        public int c;
        public boolean da;
        public int i;
        public int n;
        public final com.byazt.mk.ve sp;
        public int tt;
        public int uj;
        public ve[] ve;
        public final boolean x;

        public tt(com.byazt.mk.ve veVar) {
            this(4096, true, veVar);
        }

        public tt(int i, boolean z, com.byazt.mk.ve veVar) {
            this.i = Integer.MAX_VALUE;
            ve[] veVarArr = new ve[8];
            this.ve = veVarArr;
            this.uj = veVarArr.length - 1;
            this.n = 0;
            this.f1073a = 0;
            this.c = i;
            this.tt = i;
            this.x = z;
            this.sp = veVar;
        }

        private void c() {
            Arrays.fill(this.ve, (Object) null);
            this.uj = this.ve.length - 1;
            this.n = 0;
            this.f1073a = 0;
        }

        private int tt(int i) {
            int i2;
            int i3 = 0;
            if (i > 0) {
                int length = this.ve.length;
                while (true) {
                    length--;
                    i2 = this.uj;
                    if (length < i2 || i <= 0) {
                        break;
                    }
                    i -= this.ve[length].i;
                    this.f1073a -= this.ve[length].i;
                    this.n--;
                    i3++;
                }
                ve[] veVarArr = this.ve;
                System.arraycopy(veVarArr, i2 + 1, veVarArr, i2 + 1 + i3, this.n);
                ve[] veVarArr2 = this.ve;
                int i4 = this.uj;
                Arrays.fill(veVarArr2, i4 + 1, i4 + 1 + i3, (Object) null);
                this.uj += i3;
            }
            return i3;
        }

        private void c(ve veVar) {
            int i = veVar.i;
            int i2 = this.tt;
            if (i > i2) {
                c();
                return;
            }
            tt((this.f1073a + i) - i2);
            int i3 = this.n + 1;
            ve[] veVarArr = this.ve;
            if (i3 > veVarArr.length) {
                ve[] veVarArr2 = new ve[veVarArr.length * 2];
                System.arraycopy(veVarArr, 0, veVarArr2, veVarArr.length, veVarArr.length);
                this.uj = this.ve.length - 1;
                this.ve = veVarArr2;
            }
            int i4 = this.uj;
            this.uj = i4 - 1;
            this.ve[i4] = veVar;
            this.n++;
            this.f1073a += i;
        }

        /* JADX WARN: Code duplicated, block: B:22:0x006b  */
        /* JADX WARN: Code duplicated, block: B:26:0x0072  */
        /* JADX WARN: Code duplicated, block: B:28:0x007a  */
        /* JADX WARN: Code duplicated, block: B:30:0x0086  */
        /* JADX WARN: Code duplicated, block: B:33:0x009a A[DONT_INVERT] */
        /* JADX WARN: Code duplicated, block: B:34:0x009c  */
        /* JADX WARN: Code duplicated, block: B:37:0x00a9  */
        /* JADX WARN: Code duplicated, block: B:38:0x00b1  */
        /* JADX WARN: Code duplicated, block: B:40:0x00b5  */
        /* JADX WARN: Code duplicated, block: B:41:0x00c4  */
        /* JADX WARN: Code duplicated, block: B:46:0x00dd  */
        /* JADX WARN: Code duplicated, block: B:55:0x0092 A[SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:57:0x00a4 A[SYNTHETIC] */
        /* JADX WARN: Code duplicated, block: B:58:0x00a4 A[SYNTHETIC] */
        public void c(List<ve> list) throws IOException {
            int length;
            int length2;
            int i;
            int length3;
            if (this.da) {
                int i2 = this.i;
                if (i2 < this.tt) {
                    c(i2, 31, 32);
                }
                this.da = false;
                this.i = Integer.MAX_VALUE;
                c(this.tt, 31, 32);
            }
            int size = list.size();
            for (int i3 = 0; i3 < size; i3++) {
                ve veVar = list.get(i3);
                com.byazt.mk.a aVarA = veVar.sp.a();
                com.byazt.mk.a aVar = veVar.x;
                Integer num = uj.tt.get(aVarA);
                if (num != null) {
                    length = num.intValue() + 1;
                    if (length <= 1 || length >= 8) {
                        length2 = length;
                        length = -1;
                    } else if (!com.byazt.kh.ve.c(uj.c[length - 1].x, aVar)) {
                        if (com.byazt.kh.ve.c(uj.c[length].x, aVar)) {
                            length2 = length;
                            length++;
                        } else {
                            length2 = length;
                            length = -1;
                        }
                    }
                    if (length == -1) {
                        length3 = this.ve.length;
                        for (i = this.uj + 1; i < length3; i++) {
                            if (!com.byazt.kh.ve.c(this.ve[i].sp, aVarA)) {
                                if (com.byazt.kh.ve.c(this.ve[i].x, aVar)) {
                                    length = uj.c.length + (i - this.uj);
                                    break;
                                } else if (length2 == -1) {
                                    length2 = (i - this.uj) + uj.c.length;
                                }
                            }
                        }
                    }
                    if (length != -1) {
                        c(length, WorkQueueKt.MASK, 128);
                    } else if (length2 == -1) {
                        this.sp.i(64);
                        c(aVarA);
                        c(aVar);
                        c(veVar);
                    } else if (!aVarA.c(ve.c) && !ve.f1074a.equals(aVarA)) {
                        c(length2, 15, 0);
                        c(aVar);
                    } else {
                        c(length2, 63, 64);
                        c(aVar);
                        c(veVar);
                    }
                } else {
                    length = -1;
                }
                length2 = length;
                if (length == -1) {
                    length3 = this.ve.length;
                    while (i < length3) {
                        if (!com.byazt.kh.ve.c(this.ve[i].sp, aVarA)) {
                            if (com.byazt.kh.ve.c(this.ve[i].x, aVar)) {
                                length = uj.c.length + (i - this.uj);
                                break;
                            } else if (length2 == -1) {
                                length2 = (i - this.uj) + uj.c.length;
                            }
                        }
                    }
                }
                if (length != -1) {
                    c(length, WorkQueueKt.MASK, 128);
                } else if (length2 == -1) {
                    this.sp.i(64);
                    c(aVarA);
                    c(aVar);
                    c(veVar);
                } else if (!aVarA.c(ve.c)) {
                    c(length2, 63, 64);
                    c(aVar);
                    c(veVar);
                } else {
                    c(length2, 63, 64);
                    c(aVar);
                    c(veVar);
                }
            }
        }

        public void c(int i, int i2, int i3) {
            if (i < i2) {
                this.sp.i(i | i3);
                return;
            }
            this.sp.i(i3 | i2);
            int i4 = i - i2;
            while (i4 >= 128) {
                this.sp.i(128 | (i4 & WorkQueueKt.MASK));
                i4 >>>= 7;
            }
            this.sp.i(i4);
        }

        public void c(com.byazt.mk.a aVar) throws IOException {
            if (this.x && sl.c().c(aVar) < aVar.sp()) {
                com.byazt.mk.ve veVar = new com.byazt.mk.ve();
                sl.c().c(aVar, veVar);
                com.byazt.mk.a aVarYp = veVar.yp();
                c(aVarYp.sp(), WorkQueueKt.MASK, 128);
                this.sp.tt(aVarYp);
                return;
            }
            c(aVar.sp(), WorkQueueKt.MASK, 0);
            this.sp.tt(aVar);
        }

        public void c(int i) {
            this.c = i;
            int iMin = Math.min(i, 16384);
            int i2 = this.tt;
            if (i2 == iMin) {
                return;
            }
            if (iMin < i2) {
                this.i = Math.min(this.i, iMin);
            }
            this.da = true;
            this.tt = iMin;
            tt();
        }

        private void tt() {
            int i = this.tt;
            int i2 = this.f1073a;
            if (i < i2) {
                if (i == 0) {
                    c();
                } else {
                    tt(i2 - i);
                }
            }
        }
    }

    public static com.byazt.mk.a c(com.byazt.mk.a aVar) throws IOException {
        int iSp = aVar.sp();
        for (int i = 0; i < iSp; i++) {
            byte bC = aVar.c(i);
            if (bC >= 65 && bC <= 90) {
                throw new IOException("PROTOCOL_ERROR response malformed: mixed case name: " + aVar.c());
            }
        }
        return aVar;
    }
}
