package com.czhj.sdk.common.Database;

import android.text.TextUtils;
import com.baidu.mobads.sdk.internal.a;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class SQLiteBuider {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f2232a = "SQLiteBuider";
    private static Map<String, String> b;

    public static class CreateTable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        String f2233a;
        String b;

        public static class Builder {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            private String f2234a = null;
            private Map<String, String> b = null;
            private Map<String, String> c = null;
            private boolean d;

            public Builder autoincrement(boolean z) {
                this.d = z;
                return this;
            }

            public CreateTable build() {
                StringBuilder sb = new StringBuilder("create table if not exists ");
                sb.append(this.f2234a);
                sb.append(" ( ");
                List listB = SQLiteBuider.b(this.b);
                if (listB.size() > 1) {
                    Iterator it = SQLiteBuider.b(this.c).iterator();
                    while (it.hasNext()) {
                        sb.append((String) it.next()).append(" ,");
                    }
                    sb.append(" primary key ( ");
                    Iterator<String> it2 = this.b.keySet().iterator();
                    while (it2.hasNext()) {
                        sb.append(it2.next());
                        if (it2.hasNext()) {
                            sb.append(" ,");
                        } else {
                            sb.append(" )");
                        }
                    }
                } else {
                    sb.append(this.d ? "id integer primary key AUTOINCREMENT" : String.format("%s primary key ", listB.get(0)));
                    this.c.remove(this.b.keySet().iterator().next());
                    for (String str : SQLiteBuider.b(this.c)) {
                        sb.append(" ,");
                        sb.append(str).append(" ");
                    }
                }
                sb.append(" ); ");
                CreateTable createTable = new CreateTable();
                createTable.b = sb.toString();
                createTable.f2233a = this.f2234a;
                return createTable;
            }

            public Builder setColumns(Map<String, String> map) {
                this.c = map;
                return this;
            }

            public Builder setPrimaryKey(String str, String str2) {
                if (this.b == null) {
                    this.b = new HashMap();
                }
                this.b.put(str, str2);
                return this;
            }

            public Builder setTableName(String str) {
                this.f2234a = str;
                return this;
            }
        }
    }

    public static class CreateTriggerBuilder {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private String f2235a = null;
        private String b = null;
        private String c = null;
        private String d = null;

        public String build() {
            return String.format("create trigger if not exists %s after %s on %s begin %s end;", this.f2235a, this.b, this.c, this.d);
        }

        public CreateTriggerBuilder setExecSql(String str) {
            this.d = str;
            return this;
        }

        public CreateTriggerBuilder setOnAction(String str) {
            this.b = str;
            return this;
        }

        public CreateTriggerBuilder setOnTableName(String str) {
            this.c = str;
            return this;
        }

        public CreateTriggerBuilder setTriggerName(String str) {
            this.f2235a = str;
            return this;
        }
    }

    public static class Insert {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        String f2236a;
        String b;
        Map<String, Object> c;
        List<Object> d;

        public static class Builder {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            private String f2237a = null;
            private Map<String, Object> b = null;

            public Insert build() {
                List<Object> listAsList = Arrays.asList(this.b.keySet().toArray());
                StringBuilder sb = new StringBuilder("insert or replace into ");
                sb.append(this.f2237a);
                StringBuilder sb2 = new StringBuilder("(");
                StringBuilder sb3 = new StringBuilder("(");
                int i = 0;
                while (i < listAsList.size()) {
                    sb2.append(listAsList.get(i));
                    sb3.append("?");
                    i++;
                    if (i < listAsList.size()) {
                        sb2.append(", ");
                        sb3.append(", ");
                    }
                }
                sb2.append(")");
                sb3.append(")");
                sb.append((CharSequence) sb2).append(" values ").append((CharSequence) sb3);
                Insert insert = new Insert();
                insert.f2236a = this.f2237a;
                insert.d = listAsList;
                insert.c = this.b;
                insert.b = sb.toString();
                return insert;
            }

            public void setColumnValues(Map<String, Object> map) {
                this.b = map;
            }

            public void setTableName(String str) {
                this.f2237a = str;
            }
        }

        public List<Object> getColumns() {
            return this.d;
        }

        public String getSql() {
            return this.b;
        }

        public String getTableName() {
            return this.f2236a;
        }

        public Map<String, Object> getValues() {
            return this.c;
        }
    }

    public static class Update {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        String f2238a;
        String b;
        Map<String, Object> c;
        String d;

        public static class Builder {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            private String f2239a = null;
            private Map<String, Object> b = null;
            private String c = null;

            public Update build() {
                StringBuilder sb = new StringBuilder("update ");
                sb.append(this.f2239a);
                sb.append(" set ");
                Iterator<String> it = this.b.keySet().iterator();
                while (it.hasNext()) {
                    String next = it.next();
                    sb.append(next + " = " + this.b.get(next));
                    if (it.hasNext()) {
                        sb.append(", ");
                    }
                }
                if (!TextUtils.isEmpty(this.c)) {
                    sb.append(" " + this.c);
                }
                Update update = new Update();
                update.f2238a = this.f2239a;
                update.c = this.b;
                update.d = this.c;
                update.b = sb.toString();
                return update;
            }

            public void setColumnValues(Map<String, Object> map) {
                this.b = map;
            }

            public void setTableName(String str) {
                this.f2239a = str;
            }

            public void setWhere(String str) {
                this.c = str;
            }
        }

        public String getSql() {
            return this.b;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static List<String> b(Map<String, String> map) {
        ArrayList arrayList = new ArrayList(map.size());
        for (String str : map.keySet()) {
            String lowerCase = map.get(str).toLowerCase();
            lowerCase.hashCode();
            String str2 = a.b;
            switch (lowerCase) {
                case "int":
                case "long":
                    str2 = "integer";
                    break;
                case "text":
                case "java.lang.string":
                    break;
                default:
                    str2 = "blob";
                    break;
            }
            arrayList.add(String.format("%s %s ", str, str2));
        }
        return arrayList;
    }
}
